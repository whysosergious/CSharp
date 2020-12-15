using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace databases {
		public partial class Databases : Form {

				string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
						AttachDbFilename=D:\work\csharp\csharp\databases\testDB.mdf;
						Integrated Security=True";
				//----

				public Databases() {
						InitializeComponent();
				}

				private void btnGetData_Click(object sender, EventArgs e) {
						tbxResult.Clear();

						string query =
								$"SELECT * FROM users WHERE userID={tbxGetByID.Text}";

						using (SqlConnection connection = new SqlConnection(connectionString)) {
								connection.Open();

								using (SqlCommand command = new SqlCommand(query, connection)) {
										SqlDataReader reader = command.ExecuteReader();

										while (reader.Read()) {

												for (int i = 1; i < reader.FieldCount; i++) {

														tbxResult.AppendText(reader.GetString(i) + " ");
												}

												tbxResult.AppendText(System.Environment.NewLine);
										}
										reader.Close();
								}
						}
				}

				private void btnSaveData_Click(object sender, EventArgs e) {
						string query =
								$"INSERT users (first_name, last_name)" +
								$"VALUES ('{tbxNewFirstName.Text}', '{tbxNewLastName.Text}')";

						using (SqlConnection connection = new SqlConnection(connectionString)) {
								connection.Open();
								using (SqlCommand command = new SqlCommand(query, connection)) {
										int unchangedRowsCount = command.ExecuteNonQuery();
								}
						}
				}
		}
}
