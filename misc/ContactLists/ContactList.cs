using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactLists {
		public partial class ContactList : Form {

				// Creating holders for dialog file, listbox items and IDs for them
				string activeFile = null;
				dynamic activeContact = null;
				int contactCount = 0;

				// Finding current directory Path for dynamic File saving at application location
				string curDir = System.AppDomain.CurrentDomain.BaseDirectory;

				public FileList list = new FileList();


				/// <summary>
				/// Main method
				/// </summary>
				public ContactList() {

						string usrDir = curDir.Substring(0, curDir.IndexOf("\\ContactLists")) + "\\ContactLists\\userFiles";

						InitializeComponent();

						dlgOpenFile.InitialDirectory = usrDir;
						dlgSaveFile.InitialDirectory = usrDir;
				}


				/// <summary>
				/// Class to hold the List for File contacts
				/// </summary>
				public class FileList {
						public List<Contact> contacts = new List<Contact>();
				}


				/// <summary>
				/// Main List class
				/// </summary>
				public class Contact {

						private int contactID = 0;
						private string firstName = "";
						private string lastName = "";
						private string email = "";
						private string phoneNr = "";
						private string comment = "";

						// Constructor
						public Contact (int contactID, string firstName, string lastName, string email, string phoneNr, string comment) {
								this.contactID = contactID;
								this.firstName = firstName;
								this.lastName = lastName;
								this.email = email;
								this.phoneNr = phoneNr;
								this.comment = comment;
						}

						// Method to update values in already existing list objects
						//	(maybe I should combine this with the main constructor?)
						public void UpdateValues(string firstName, string lastName, string email, string phoneNr, string comment) {
								this.firstName = firstName;
								this.lastName = lastName;
								this.email = email;
								this.phoneNr = phoneNr;
								this.comment = comment;
						}

						// Get/Set Properties 
						//	(self explanatory)
						public int ContactID {
								get { return contactID; }
								set { contactID = value; }
						}

						public string FirstName {
								get { return firstName; }
								set { firstName = value; }
						}

						public string LastName {
								get { return lastName; }
								set { lastName = value; }
						}

						public string Email {
								get { return email; }
								set { email = value; }
						}

						public string PhoneNr {
								get { return phoneNr; }
								set { phoneNr = value; }
						}

						public string Comment {
								get { return comment; }
								set { comment = value; }
						}

						// Display as string in Listbox
						public override string ToString() {
								return firstName + " " + lastName;
						}
				}


				// Document Managment Methods
				// --------------------------------
				/// <summary>
				/// Create new Document
				/// </summary>
				public void NewFile() {

						activeFile = null;
						contactCount = 0;

						ClearAllData();

						this.Text = "Untitled Contact List";
				}


				/// <summary>
				/// Open existing Document
				/// </summary>
				/// <param name="filename">File path and name</param>
				public void OpenFile(string filename) {

						ClearAllData();

						FileStream inStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
						BinaryReader reader = new BinaryReader(inStream);

						// Get Iteration of contacts in file
						int listCount = reader.ReadInt32();

						// Read contact values and add them to List
						for (int i=0; i<listCount; i++) {
								int contactID = reader.ReadInt32();
								string firstName = reader.ReadString();
								string lastName = reader.ReadString();
								string email = reader.ReadString();
								string phoneNr = reader.ReadString();
								string comment = reader.ReadString();

								Contact newContact;
								newContact = new Contact(contactID, firstName, lastName, email, phoneNr, comment);

								list.contacts.Add(newContact);
								lbxContacts.Items.Add(newContact);

								// Determine the next contact ID from the last iteration
								if (i == listCount - 1) {
										contactCount = contactID + 1;
								}
						}

						reader.Dispose();

						dlgOpenFile.FileName = Path.GetFileName(activeFile);
						//dlgOpenFile.FileName = filename.Substring(filename.LastIndexOf("\\") + 1);    // substring alt

						this.Text = Path.GetFileNameWithoutExtension(activeFile);
				}


				/// <summary>
				/// Save Current Document
				/// </summary>
				/// <param name="filename">File path and name</param>
				public void SaveFile(string filename) {

						FileStream outStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
						BinaryWriter writer = new BinaryWriter(outStream);

						// Determine iteration of contacts in document and save in File
						int contactsCount = list.contacts.Count;
						writer.Write(contactsCount);

						// Save contact information
						for (int i=0; i<contactsCount; i++) {
								writer.Write(list.contacts[i].ContactID);
								writer.Write(list.contacts[i].FirstName);
								writer.Write(list.contacts[i].LastName);
								writer.Write(list.contacts[i].Email);
								writer.Write(list.contacts[i].PhoneNr);
								writer.Write(list.contacts[i].Comment);
						}

						writer.Dispose();

						activeFile = filename;

						this.Text = Path.GetFileNameWithoutExtension(activeFile);
				}


				// Workspace Methods
				// --------------------------------
				/// <summary>
				/// Clear listbox selection, all fields and change button text
				/// </summary>
				public void ClearAllFields() {

						activeContact = null;

						lbxContacts.ClearSelected();

						tbxFirstName.Clear();
						tbxLastName.Clear();
						tbxEmail.Clear();
						tbxPhoneNr.Clear();
						tbxComment.Clear();

						btnSaveContact.Text = "Create New";
				}


				/// <summary>
				/// Clear all fields and List data
				/// </summary>
				public void ClearAllData() {

						ClearAllFields();

						list.contacts.Clear();
						lbxContacts.Items.Clear();
				}


				/// <summary>
				/// Clear and Update Items in listbox
				/// </summary>
				private void UpdateContactList() {

						lbxContacts.Items.Clear();

						foreach (Contact contacts in list.contacts) lbxContacts.Items.Add(contacts);

						// Reselect the last selected Item
						lbxContacts.SelectedItem = activeContact;
				}


				/// <summary>
				/// Add New Contact or Save Changes of existing if selected
				/// </summary>
				public void SaveContact() {

						string firstName = tbxFirstName.Text;
						string lastName = tbxLastName.Text;
						string email = tbxEmail.Text;
						string phoneNr = tbxPhoneNr.Text;
						string comment = tbxComment.Text;

						if (activeContact == null) {
								Contact newContact = new Contact(contactCount++, firstName, lastName, email, phoneNr, comment);

								list.contacts.Add(newContact);
								lbxContacts.Items.Add(newContact);

								ClearAllFields();
						} else {
								activeContact.UpdateValues(firstName, lastName, email, phoneNr, comment);

								UpdateContactList();
						}
				}


				/// <summary>
				/// Delete existing Contact by ID
				/// </summary>
				public void DeleteContact() {

						if (activeContact != null) {
								list.contacts.RemoveAll(x => x.ContactID == activeContact.ContactID);

								UpdateContactList();
								ClearAllFields();
						}
				}


				/// <summary>
				/// Display Selected contact information and change button text
				/// </summary>
				public void DisplayActiveContact() {

						tbxFirstName.Text = activeContact.FirstName;
						tbxLastName.Text = activeContact.LastName;
						tbxEmail.Text = activeContact.Email;
						tbxPhoneNr.Text = activeContact.PhoneNr;
						tbxComment.Text = activeContact.Comment;

						btnSaveContact.Text = "Save Changes";
				}


				// Menu Strip Actions
				//	(most of these I think are self explanatory)
				// --------------------------------
				private void tmiNewFile_Click(object sender, EventArgs e) {

						NewFile();
				}

				private void tmiOpenFile_Click(object sender, EventArgs e) {

						if (DialogResult.OK == dlgOpenFile.ShowDialog()) {
								activeFile = dlgOpenFile.FileName;

								OpenFile(activeFile);
						}
				}

				private void tmiSaveFile_Click(object sender, EventArgs e) {

						if (activeFile == null) {

								if (DialogResult.OK == dlgSaveFile.ShowDialog()) {
										activeFile = dlgSaveFile.FileName;

										SaveFile(activeFile);
								}
						} else {

								SaveFile(activeFile);
						}
				}

				private void tmiSaveFileAs_Click(object sender, EventArgs e) {

						if (DialogResult.OK == dlgSaveFile.ShowDialog()) {
								activeFile = dlgSaveFile.FileName;

								SaveFile(activeFile);
						}
				}

				private void tmiExitApp_Click(object sender, EventArgs e) {

						System.Windows.Forms.Application.Exit();
				}

				private void tmiNewContact_Click(object sender, EventArgs e) {

						UpdateContactList();
						ClearAllFields();
				}

				private void tmiDeleteContact_Click(object sender, EventArgs e) {

						DeleteContact();
				}


				// Workspace Actions
				// --------------------------------
				private void btnSaveContact_Click(object sender, EventArgs e) {

						if (!string.IsNullOrEmpty(tbxFirstName.Text)) {
								SaveContact();
						} else {
								MessageBox.Show("First name is obligatory");

								return;
						}
				}

				private void btnDeleteContact_Click(object sender, EventArgs e) {
						DeleteContact();
				}

				private void lbxContacts_SelectedIndexChanged(object sender, EventArgs e) {

						activeContact = lbxContacts.SelectedItem;

						if (activeContact != null) {
								DisplayActiveContact();
						}
				}
		}
}
