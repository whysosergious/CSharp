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

namespace openAndSave {
		public partial class OpenAndSave : Form {
				string activeFile = null;

				public OpenAndSave() {
						InitializeComponent();
						this.Text = "New Document";
				}

				private void tmiNew_Click(object sender, EventArgs e) {
						NewFile();
				}

				private void tmiOpen_Click(object sender, EventArgs e) {
						DialogResult result = dlgOpenFile.ShowDialog();

						if (result == DialogResult.OK) {
								OpenFile(dlgOpenFile.FileName);
						}
				}

				private void tmiSave_Click(object sender, EventArgs e) {
						if (activeFile == null) {

								if (DialogResult.OK == dlgSaveFile.ShowDialog()) {
										activeFile = dlgSaveFile.FileName;
										SaveFile(activeFile);
								}

						} else {
								SaveFile(activeFile);
						}
				}

				public void NewFile() {
						activeFile = null;

						tbxDocument.Clear();

						this.Text = "New Document";
				}

				public void OpenFile(string filename) {
						tbxDocument.Clear();

						FileStream inStream = new FileStream(filename, FileMode.Open, FileAccess.Read);

						StreamReader reader = new StreamReader(inStream);

						string fileText = reader.ReadToEnd();

						tbxDocument.Text = fileText;

						activeFile = dlgOpenFile.FileName;

						this.Text = System.IO.Path.GetFileNameWithoutExtension(activeFile);

						reader.Dispose();
				}

				public void SaveFile(string filename) {
						FileStream outStream = new FileStream(filename, FileMode.Create, FileAccess.Write);

						StreamWriter writer = new StreamWriter(outStream);

						writer.Write(tbxDocument.Text);

						this.Text = System.IO.Path.GetFileNameWithoutExtension(activeFile);

						writer.Dispose();
				}
		}
}
