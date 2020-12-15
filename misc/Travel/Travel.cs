using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Travel {
		public partial class Travel : Form {

				public int tgtInUrl = 4;

				dynamic selectedPlace = null;
				public int listItemCount = 0;
				public int newPlaceID = 0;

				string curDir = System.AppDomain.CurrentDomain.BaseDirectory;

				string connectionString = "";

				public PlaceList list = new PlaceList();

				public class PlaceList {
						public List<Place> places = new List<Place>();
				}

				// Main method
				public Travel() {
						connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
						AttachDbFilename=" + curDir + @"cities.mdf;
						Integrated Security=True";

						InitializeComponent();
						
						LoadFromDB();
				}


				/// <summary>
				/// Waits for the browser to finish loading the DOM
				/// </summary>
				/// <param name="sender"></param>
				/// <param name="e"></param>
				private void mapsBrowserLoaded(object sender, WebBrowserDocumentCompletedEventArgs e) {
						ProcessBrowserUrl();
				}


				/// <summary>
				/// Parses the City Name and Location from the url
				/// </summary>
				public void ProcessBrowserUrl() {
						string currentUrl = "";

						string city = "";
						string lat = "";
						string lon = "";

						if (mapsBrowser.Url != null) {
								currentUrl = mapsBrowser.Url.AbsoluteUri;
						}

						string[] dataDvdr = { "/" };
						string[] dataList = currentUrl.Split(dataDvdr, 6, StringSplitOptions.RemoveEmptyEntries);
						
						// Check if a place is selected, not found or still searching
						if (currentUrl.IndexOf("?q=") >= 0) {
								MessageBox.Show("Still searching");
						} else if (dataList[3] == "search" || dataList[3][0].ToString() == "@") {
								MessageBox.Show("Nothing selected, try searching");
						} else {
								int cityEndIndex = dataList[tgtInUrl].IndexOf(",");

								// check if search result returns multiple data
								if (cityEndIndex > 1) {
										// returns nly the name
										cityEndIndex = dataList[tgtInUrl].IndexOf(",");
										city = dataList[tgtInUrl].Substring(0, cityEndIndex);
								} else   {
										city = dataList[tgtInUrl];
								}

								city = city.Replace("+"," ");
								Console.WriteLine(city);

								lat = dataList[tgtInUrl + 1].Substring(1, 5);
								int lonIndex = dataList[tgtInUrl + 1].IndexOf(",") + 1;
								lon = dataList[tgtInUrl + 1].Substring(lonIndex, 5);

								// searching for place in list
								dynamic listCheck = list.places.Find(x => x.stad == city);

								// if location doestn exist in list, save.
								if (listCheck == null) {

										newPlaceID++;
										Place newPlace = new Place(newPlaceID, city, lat, lon);

										list.places.Add(newPlace);
										lbxSavedList.Items.Add(newPlace);

										// to the database!! :D
										string query = $"INSERT city (Id, stad, lat, lon)" +
														$" VALUES ('{newPlaceID}', '{city}', '{lat}', '{lon}'); ";

										using (SqlConnection connection = new SqlConnection(connectionString)) {
												connection.Open();
												using (SqlCommand command = new SqlCommand(query, connection)) {
														int unchangedRowsCount = command.ExecuteNonQuery();
												}
										}
								} else {
										MessageBox.Show("Already in the list");
								}
						}
				}
				

				/// <summary>
				/// Places list class
				/// </summary>
				public partial class Place {
						public int Id { get; set; }
						public string stad { get; set; }
						public string lat { get; set; }
						public string lon { get; set; }

						public Place(int Id, string stad, string lat, string lon) {
								this.Id = Id;
								this.stad = stad;
								this.lat = lat;
								this.lon = lon;
						}

						// Make it prettier to display in the ListBox
						public override string ToString() {
								return $"{stad}";
						}
				}

				

				// Get data from .mdf
				public void LoadFromDB() {
						lbxSavedList.Items.Clear();

						int placeID = 1;

						string query = $"SELECT * FROM city";

						using (SqlConnection connection = new SqlConnection(connectionString)) {
								connection.Open();

								using (SqlCommand command = new SqlCommand(query, connection)) {
										
										SqlDataReader reader = command.ExecuteReader();

										while (reader.Read()) {

												placeID = reader.GetInt32(0);

												Place newPlace = new Place(placeID, reader["stad"].ToString(), reader["lat"].ToString(), reader["lon"].ToString());

												// Save objects in a list and display then in the ListBox
												list.places.Add(newPlace);
												lbxSavedList.Items.Add(newPlace);

												listItemCount++;

												if (newPlaceID < placeID) {
														newPlaceID = placeID + 1;
												}
										}

										reader.Close();
								}
						}
				}


				// Removes entry from external and local sources...
				public void DeleteFromList() {
						int tgtID = selectedPlace.Id;
						list.places.RemoveAll(x => x.Id == tgtID);
						lbxSavedList.Items.Remove(selectedPlace);

						string query = $"DELETE FROM city WHERE Id={tgtID}";

						using (SqlConnection connection = new SqlConnection(connectionString)) {
								connection.Open();
								using (SqlCommand command = new SqlCommand(query, connection)) {
										int unchangedRowsCount = command.ExecuteNonQuery();
								}
						}
				}


				// listbox item selection listener
				private void lbxSavedList_SelectedIndexChanged(object sender, EventArgs e) {

						selectedPlace = lbxSavedList.SelectedItem;
						if (selectedPlace != null) {
								btnShowOnMap.Enabled = true;
								btnDelFromList.Enabled = true;
						} else {
								btnShowOnMap.Enabled = false;
								btnDelFromList.Enabled = false;
						}
				}


				// ------------ BUttONs!!!
				
				/// <summary>
				/// Save to list
				/// </summary>
				/// <param name="sender"></param>
				/// <param name="e"></param>
				private void btnSaveToList_Click(object sender, EventArgs e) {
						ProcessBrowserUrl();
				}

				/// <summary>
				/// Search in list
				/// </summary>
				/// <param name="sender"></param>
				/// <param name="e"></param>
				private void btnSearchInList_Click(object sender, EventArgs e) {
						string searchInput = char.ToUpper(tbxSearchInList.Text[0]) + tbxSearchInList.Text.Substring(1);
						try {
								object result = list.places.Find(x => x.stad == searchInput);
								lbxSavedList.SelectedItem = result;
								Console.WriteLine(result.ToString());
						} catch {
								DialogResult dialogResult = MessageBox.Show($"{searchInput} does not seem to be saved in your list.\nLook for it on the map?", "Search not found", MessageBoxButtons.YesNo);
								if (dialogResult == DialogResult.Yes) {
										mapsBrowser.Navigate($"http://maps.google.com/?q={searchInput}");
								} else if (dialogResult == DialogResult.No) {
										// Not much to do here.. maybe clear the textbox..
								}
						}
				}

				/// <summary>
				/// Show selected on map
				/// </summary>
				/// <param name="sender"></param>
				/// <param name="e"></param>
				private void btnShowOnMap_Click(object sender, EventArgs e) {
						mapsBrowser.Navigate($"https://www.google.com/maps/place/{ selectedPlace.stad }/@{ selectedPlace.lat },{ selectedPlace.lon }");
				}

				/// <summary>
				/// Delete from list
				/// </summary>
				/// <param name="sender"></param>
				/// <param name="e"></param>
				private void btnDelFromList_Click(object sender, EventArgs e) {
						DeleteFromList();
				}
		}
}
