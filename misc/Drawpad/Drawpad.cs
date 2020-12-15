using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawpad {

    public partial class Drawpad : Form {

        Point lastPoint = Point.Empty;

        bool isMouseDown = new Boolean();

        public Drawpad() {

            InitializeComponent();

        }

        private void pbxCanvas_MouseDown(object sender, MouseEventArgs e) {

            lastPoint = e.Location;

            isMouseDown = true;

        }
      private void pbxCanvas_MouseMove(object sender, MouseEventArgs e) {
            
            if (isMouseDown == true)  {

                if (lastPoint != null) {

                    if (pbxCanvas.Image == null) {

                        Bitmap bmp = new Bitmap(pbxCanvas.Width, pbxCanvas.Height);

                        pbxCanvas.Image = bmp; 

                    }
                    

                    using (Graphics g = Graphics.FromImage(pbxCanvas.Image)) {
                        int brushSize = 0;
                        int fillerSize = 0;

                        if(int.TryParse(tbxBrushSize.Text, out brushSize)) {
                            fillerSize = brushSize + 3;
                        }

                        Pen mainPen = new Pen(Color.Black, brushSize);
                        Pen fillerPen = new Pen(Color.FromArgb(50, 0, 0, 0), fillerSize);

                        if (rbnBlack.Checked == true) {
                            mainPen = new Pen(Color.Black, brushSize);
                            fillerPen = new Pen(Color.FromArgb(50, 0, 0, 0), fillerSize);
                        } else if (rbnWhite.Checked == true) {
                            mainPen = new Pen(Color.White, brushSize);
                            fillerPen = new Pen(Color.FromArgb(50, 255, 255, 255), fillerSize);
                        }

                        

                        mainPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        mainPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        fillerPen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
                        fillerPen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        g.DrawLine(mainPen, lastPoint, e.Location);
                        g.DrawLine(fillerPen, lastPoint, e.Location);

                    }

                    pbxCanvas.Invalidate();

                    lastPoint = e.Location;

                }
            }
        }

        private void pbxCanvas_MouseUp(object sender, MouseEventArgs e) {

            isMouseDown = false;

            lastPoint = Point.Empty;

        }

        private void btnUndo_Click(object sender, EventArgs e) {

            if (pbxCanvas.Image != null) {

                pbxCanvas.Image = null;

                Invalidate();

            }
        }
    }
}