using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingList {
		public partial class shoppingList : Form {

				/// <summary>
				/// New BaseClass
				/// </summary>
				public List<Item> ItemList = new List<Item>();

				/// <summary>
				/// Initialize app
				/// </summary>
				public shoppingList() {
						InitializeComponent();
				}

				/// <summary>
				/// Base Class
				/// </summary>
				public abstract class Item {
						protected string name = "";

						/// <summary>
						/// Contructor
						/// </summary>
						public Item(string name) {
								this.name = name;
						}

						/// <summary>
						/// Calculate total cost of items in the list
						/// </summary>
						/// <returns>Total price</returns>
						//public virtual double CalcTotPrice() {
						//		totalPrice += p;

						//		return totalPrice;
						//}
				}

				/// <summary>
				/// By FreeWeight subclass
				/// </summary>
				public class FreeWeight : Item {
						protected double kiloPrice = 0;
						protected double itemWeight = 0;
						protected double totItemPrice = 0;

						/// <summary>
						/// Bind values by FreeWeight
						/// </summary>
						/// <param name="name">Item Name</param>
						/// <param name="p">Item Price</param>
						/// <param name="a">Item Weight</param>
						public FreeWeight(string name, double p, double a) : base(name) {
								this.kiloPrice = p;
								this.itemWeight = a;
								this.totItemPrice = CalcItemPrice();
						}

						/// <summary>
						/// Calculate FreeWeight Price
						/// </summary>
						/// <returns>Weight Price</returns>
						public double CalcItemPrice() {
								double price = kiloPrice * itemWeight;
								return price;
						}

						public override string ToString() {
								return name + "   " + itemWeight + " kg.   " + kiloPrice + " kr/kg    " + CalcItemPrice() + " kr";
						}
				}

				/// <summary>
				/// By Article subclass
				/// </summary>
				public class Article : Item {
						protected double articlePrice = 0;
						protected int articleAmount = 0;

						/// <summary>
						/// Bind values by Articles
						/// </summary>
						/// <param name="name">Item Name</param>
						/// <param name="p">Item Price</param>
						/// <param name="a">Amount of Items</param>
						public Article(string name, double p, int a) : base(name) {
								this.articlePrice = p;
								this.articleAmount = a;
						}

						/// <summary>
						/// Calculate Article Price
						/// </summary>
						/// <returns>Article Price</returns>
						public double CalcItemPrice() {
								double price = articlePrice * articleAmount;
								return price;
						}

						public override string ToString() {
								return name + "   " + articleAmount + " st.   " + articlePrice + " kr/st    " + CalcItemPrice() + " kr";
						}
				}

				double totalPrice = 0;
				/// <summary>
				/// Button Click Event Listener
				/// </summary>
				/// <param name="sender">Add Button</param>
				/// <param name="e">Click Event</param>
				private void btnRegister_Click(object sender, EventArgs e) {
						string name;
						double price;

						if (!double.TryParse(tbxPrice.Text, out price)) {
								MessageBox.Show("Invalid Price");
								return;
						}
						if (!string.IsNullOrEmpty(tbxItem.Text)) {
								name = tbxItem.Text;
						} else {
								MessageBox.Show("Invalid Name");
								return;
						}

						if (rbnWeight.Checked == true) {
								double weight;

								if (!double.TryParse(tbxAmount.Text, out weight)) {
										MessageBox.Show("Invalid Price");
										return;
								}

								Item newItem;
								newItem = new FreeWeight(name, price, weight);

								totalPrice += price * weight;
								tbxTotPrice.Text = totalPrice.ToString();

								ItemList.Add(newItem);
								lbxList.Items.Add(newItem);

						} else if (rbnArticle.Checked == true) {
								int amount;

								if (!int.TryParse(tbxAmount.Text, out amount)) {
										MessageBox.Show("Invalid Price");
										return;
								}

								Item newItem;
								newItem = new Article(name, price, amount);

								totalPrice += price * amount;
								tbxTotPrice.Text = totalPrice.ToString();

								ItemList.Add(newItem);
								lbxList.Items.Add(newItem);

						}
				}
		}
}
