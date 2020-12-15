using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipart {
		public partial class Clipart : Form {

				private Objects objects = new Objects();

				public Clipart() {
						InitializeComponent();
				}

				public class Objects {
						public List<Obj> ObjectList = new List<Obj>();
				}

				public interface IHasArea {
						double CalcArea();
				}

				// Main Class
				public abstract class Obj {
						protected string objType = "";
						protected double objHeight = 0;
						protected double objWidth = 0;

						// constructor
						public Obj(string objType, double objHeight, double objWidth) {
								this.objType = objType;
								this.objHeight = objHeight;
								this.objWidth = objWidth;
						}

				}

				public class Triangle : Obj, IHasArea {
						protected double objArea = 0;
						public Triangle(string objType, double objHeight, double objWidth, double objArea) : base(objType, objHeight, objWidth) {
								this.objArea = objArea;
						}

						public double CalcArea() {
								return objArea;
						}

						public override string ToString() {
								return objType + ": " + objHeight + "x" + objWidth + " area: " + objArea;
						}
				}

				public class Circle : Obj, IHasArea {
						protected double objArea = 0;
						public Circle(string objType, double objHeight, double objWidth, double objArea) : base(objType, objHeight, objWidth) {
								this.objArea = objArea;
						}

						public double CalcArea() {
								return objArea;
						}

						public override string ToString() {
								return objType + ": " + objHeight + "x" + objWidth + " area: " + objArea;
						}
				}

				public class Line : Obj {
						public Line(string objType, double objHeight, double objWidth) : base(objType, objHeight, objWidth) {

						}

						public override string ToString() {
								return objType + ": " + objHeight + "x" + objWidth;
						}
				}




				private void btnAddTriangle_Click(object sender, EventArgs e) {
						double objHeight;
						double objWidth;

						if(!double.TryParse(tbxHeight.Text, out objHeight)) {
								MessageBox.Show("Invalid objHeight");
								return;
						}

						if(!double.TryParse(tbxWidth.Text, out objWidth)) {
								MessageBox.Show("Invalid objWidth");
								return;
						}

						double objArea = objHeight * objWidth / 2;

						Obj newObj;
						newObj = new Triangle("Triangle", objHeight, objWidth, objArea);

						objects.ObjectList.Add(newObj);
						lbxObjects.Items.Add(newObj);
				}

				private void btnAddCircle_Click(object sender, EventArgs e) {
						double objHeight;
						double objWidth;

						if (!double.TryParse(tbxHeight.Text, out objHeight)) {
								MessageBox.Show("Invalid objHeight");
								return;
						}

						if (!double.TryParse(tbxWidth.Text, out objWidth)) {
								MessageBox.Show("Invalid objWidth");
								return;
						}

						double objArea = 3.14 * (objWidth / 2) * (objHeight / 2);

						Obj newObj;
						newObj = new Circle("Circle", objHeight, objWidth, objArea);

						objects.ObjectList.Add(newObj);
						lbxObjects.Items.Add(newObj);
				}

				private void btnAddLine_Click(object sender, EventArgs e) {
						double objHeight;
						double objWidth;

						if (!double.TryParse(tbxHeight.Text, out objHeight)) {
								MessageBox.Show("Invalid objHeight");
								return;
						}

						if (!double.TryParse(tbxWidth.Text, out objWidth)) {
								MessageBox.Show("Invalid objWidth");
								return;
						}

						Obj newObj;
						newObj = new Line("Line", objHeight, objWidth);

						objects.ObjectList.Add(newObj);
						lbxObjects.Items.Add(newObj);
				}

				private void btnCalObjArea_Click(object sender, EventArgs e) {
						double totArea = 0;

						foreach (Obj objects in objects.ObjectList) {
								//if (objects is Triangle) {
								//		totArea += (objects as Triangle).CalcArea();
								//} else if (objects is Circle) {
								//		totArea += (objects as Circle).CalcArea();
								//}

								if (objects is IHasArea) {
										totArea += (objects as IHasArea).CalcArea();
								}
						}

						tbxTotObjArea.Text = totArea.ToString();
				}
		}
}
