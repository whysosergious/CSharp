using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sort {
		public partial class Sorting : Form {

				Bunch<Player> players = new Bunch<Player>();

				public Sorting() {
						InitializeComponent();
				}

				interface IComparable {
						int CompareTo(object obj);
				}

				public class Player : IComparable<Player> {
						protected string name, score;

						public Player (string n, string s) {
								name = n;
								score = s;
						}

						public int CompareTo(Player player) {
								return name.CompareTo(player.name);
						}

						public override string ToString() {
								return name + " - " + score;
						}
				}

				public class Bunch<T> where T : IComparable<T> {
						protected int buffer;
						protected int placed;
						protected int length;
						protected string[] list;

						public Bunch() {
								buffer = 3;
								placed = 0;
								length = 3;
								list = new string[length];
						}

						protected void Expand(int size) {
								if (size < 1) return;

								string[] temp = new string[length + size];

								for (int i = 0; i < placed; i++) temp[i] = list[i];

								list = temp;
								length += size;
						}

						//protected void Reduce() {
						//		string[] temp = new string[placed];

						//		for (int i = 0; i < placed; i++) temp[i] = list[i];

						//		list = temp;
						//		length = placed;
						//}

						//public int Placed {
						//		get { return placed; }
						//}

						

						public void Sort() {
								int i, j;
								int p = placed;			if (p < 2) return;
								string a;

								for(j=1; j<p; j++) {
										a = list[j];
										i = j - 1;

										while (i>=0 && list[i].CompareTo(a) > 0) {
												list[i + 1] = list[i];
												i--;
										}

										list[i + 1] = a;
								}
						}

						/// <summary>
						/// Get string array
						/// </summary>
						/// <param name="getingTheList">wohoo</param>
						/// <returns>string array</returns>
						public string[] getList() {
								return list;
						}

						//public T this[int index] {
						//		get { return list[index]; }
						//}

						public void Register(string n, string s) {

								if (placed + 1 > length) Expand(1 + buffer);

								list[placed++] = n + " - " + s;
						}
				}

				private void btnRegister_Click(object sender, EventArgs e) {
						string name, score;
						if (string.IsNullOrEmpty(tbxName.Text)) {
								MessageBox.Show("Invalid Name");
								return;
						} else {
								name = tbxName.Text;
								score = tbxScore.Text;
						}

						Player newPlayer;
						newPlayer = new Player(name, score);

						players.Register(name, score);
						lbxList.Items.Add(newPlayer);
				}

				private void btnSort_Click(object sender, EventArgs e) {
						lbxList.Items.Clear();
						lbxList.Items.Add("Sorting..");

						players.Sort();

						string[] sortedList = players.getList();

						for (int i = 0; i < sortedList.Length; i++) {
								if (sortedList[i] == null) break;

								lbxList.Items.Add(sortedList[i]);
						}
				}
		}
}
