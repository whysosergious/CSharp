using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace side11 {
		public partial class Form1 : Form {
				public Form1() {
						InitializeComponent();
				}

				private void btnKör_Click(object sender, EventArgs e) {
						int tal1 = ParseToInt(tbxTal1.Text);

						tal1 += 5;

						tbxSvar.Text = tal1.ToString();

				}

				private int ParseToInt(string text) {
						int digit = 0;
						int positionVal = 1;
						
						for(int i = text.Length-1; i>=0; i--) {
								int digitVal = text[i] - 48;

								if (text[i] == '-') {
										digit -= digit;
										break;
								}

								digit += digitVal * positionVal;
								positionVal = positionVal * 10;
						}

						return digit;
				}
		}
}
