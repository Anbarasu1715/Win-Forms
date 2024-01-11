using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintRectangle
{
    public partial class Form1 : Form
    {

        private Point cursorPoint;
        private Control rec;
        private List<Control> rectangles = new List<Control>();
        private Control selectedRec;

        public Form1()
        {
            InitializeComponent();
            mainPanel.Click += PanelClick;
            
        }

        private void PanelClick(Object sender,EventArgs e) {
            
        }

        private void recClick(Object sender, EventArgs e) {
            selectedRec = sender as Panel;
            selectedRec.BackColor = Color.Green;
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //cursorPoint = mainPanel.PointToClient(Cursor.Position);
            cursorPoint = new Point(e.X,e.Y);
            rec = new Panel()
            {
                Location = new Point(cursorPoint.X, cursorPoint.Y),
                Size = new Size(25, 25),
                BackColor = Color.Red
            };
            rec.Click += recClick;
            rec.MouseMove += rec_MouseMove;
            rectangles.Add(rec);
            selectedRec = rec;
            mainPanel.Controls.Add(rec);
        }


        private void rec_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    selectedRec.Width += e.X - cursorPoint.X;
            //    selectedRec.Height += e.Y - cursorPoint.Y;
            //    textBox1.Text = "" + selectedRec.Width+"    "+ selectedRec.Height;
            //}
        }


        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                int width = e.X - cursorPoint.X;
                int height = e.Y - cursorPoint.Y;

                if (width < 0 && height < 0)
                {
                    selectedRec.Location = new Point(e.X, e.Y);

                    selectedRec.Size = new Size(cursorPoint.X - e.X, cursorPoint.Y - e.Y);
                }
                else if (width < 0 && height > 0)
                {
                    selectedRec.Location = new Point(e.X, cursorPoint.Y);
                    selectedRec.Size = new Size(cursorPoint.X - e.X, e.Y - cursorPoint.Y);
                }
                else if (width > 0 && height < 0)
                {
                    selectedRec.Location = new Point(cursorPoint.X, e.Y);
                    selectedRec.Size = new Size(e.X - cursorPoint.X, cursorPoint.Y - e.Y);
                }
                else if (width > 0 && height > 0)
                {
                    selectedRec.Location = cursorPoint;
                    selectedRec.Size = new Size(width, height);
                }
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                mainPanel.Controls.Remove(selectedRec);
            }
        }
    }
}
