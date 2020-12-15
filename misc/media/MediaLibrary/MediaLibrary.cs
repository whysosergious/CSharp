using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibrary {
		public partial class MediaLibrary : Form {
				List<Media> mediaList = new List<Media>();
				public MediaLibrary() {
						InitializeComponent();
				}

				private void btnRegBook_Click(object sender, EventArgs e) {
						Book newBook = new Book();
						newBook.Title = tbxBookTitle.Text;
						newBook.PageCount = int.Parse(tbxBookPages.Text);

						mediaList.Add(newBook);
						lbxLibrary.Items.Add(newBook);
				}

				private void btnRegSound_Click(object sender, EventArgs e) {
						SoundFile newSound = new SoundFile();
						newSound.Title = tbxSoundTitle.Text;
						newSound.Runtime = double.Parse(tbxSoundRuntime.Text);

						mediaList.Add(newSound);
						lbxLibrary.Items.Add(newSound);
				}

				private void btnRegVideo_Click(object sender, EventArgs e) {
						Video newVideo = new Video();
						newVideo.Title = tbxVideoTitle.Text;
						newVideo.Runtime = double.Parse(tbxVideoRuntime.Text);

						mediaList.Add(newVideo);
						lbxLibrary.Items.Add(newVideo);
				}

				public class Media {
						public string Title = "";

						public override string ToString() {
								return Title;
						}
				}

				public class Book : Media {
						public int PageCount = 0;

						public override string ToString() {
								return Title + ": " + PageCount + " pages";
						}
				}

				public class SoundFile : Media {
						public double Runtime = 0;

						public override string ToString() {
								return Title + ": " + Runtime + " minutes";
						}
				}

				public class Video : SoundFile {
						public string Res = "";

						public override string ToString() {
								return base.ToString() + " " + Res;
						}
				}
		}
}
