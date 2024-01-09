using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {

        private Point startPoint;
        private bool isMove = false;
        private Rectangle recBtn1;
        private Rectangle recBtn2;
        private Rectangle recBtn3;
        private Rectangle recBtn4;
        private Dictionary<string, Rectangle> dict = new Dictionary<string, Rectangle>();

        public Form1()
        {
            InitializeComponent();
            //displayTP.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            displayTP.Invalidated += validate;

            recBtn1 = new Rectangle(btn1.Location, btn1.Size);
            recBtn2 = new Rectangle(btn2.Location, btn2.Size);
            recBtn3 = new Rectangle(btn3.Location, btn3.Size);
            recBtn4 = new Rectangle(btn4.Location, btn4.Size);
            dict.Add("btn1", recBtn1);
            dict.Add("btn2", recBtn2);
            dict.Add("btn3", recBtn3);
            dict.Add("btn4", recBtn4);

            btn1.MouseDown += MouseDown;
            btn2.MouseDown += MouseDown;
            btn3.MouseDown += MouseDown;
            btn4.MouseDown += MouseDown;

            btn1.MouseUp += MouseUp;
            btn2.MouseUp += MouseUp;
            btn3.MouseUp += MouseUp;
            btn4.MouseUp += MouseUp;

            btn1.MouseMove += MouseMove;
            btn2.MouseMove += MouseMove;
            btn3.MouseMove += MouseMove;
            btn4.MouseMove += MouseMove;
        }


        private void validate(object sender, InvalidateEventArgs e) {
            
        }

        
        private void MouseUp(object sender, MouseEventArgs e)
        {
            
            if (isMove) {
                Button btn = sender as Button;
                Point CurrentLocation = displayTP.PointToClient(btn.PointToScreen(new Point(0, 0)));
                CurrentLocation.X += btn.Width / 2;
                CurrentLocation.Y += btn.Height / 2;
                int x =(displayTP.PointToClient(Cursor.Position).X / 139);
                int y = displayTP.PointToClient(Cursor.Position).Y / 53;

                if (x < 0) x = 0;
                if (x >= displayTP.ColumnCount) x = displayTP.ColumnCount - 1;
                if (y < 0) y = 0;
                if (y >= displayTP.RowCount) {
                    panel2.Controls.Add(btn);
                    btn.Location = dict[btn.Name].Location;
                    return;
                }


                textBox1.Text = "" + x + "    " + y;
                displayTP.Controls.Add(btn, x, y);
                btn.Dock = DockStyle.Fill;
                isMove = false;
            }

        }

        private void MouseDown(object sender, MouseEventArgs e) {
            isMove = false;
            Button btn = sender as Button;
            startPoint = e.Location;
            foreach (Control control in displayTP.Controls) {
                if (control.Name == btn.Name)
                {
                    displayTP.Controls.Remove(control);
                    textBox1.Text = ""+control.Location;
                    
                    control.Size =new System.Drawing.Size(dict[btn.Name].Size.Width, dict[btn.Name].Height);
                    
                    control.Dock = DockStyle.None;
                    control.BringToFront();
                    panel2.Controls.Add(control);
                    
                    break;
                }
            }
            
            btn.BringToFront();
        }

        private void MouseMove(object sender, MouseEventArgs e) {
            
            if (e.Button == MouseButtons.Left)
            {
               
                (sender as Button).Left += e.X - startPoint.X;
                (sender as Button).Top += e.Y - startPoint.Y;
                if (Math.Abs(e.X - startPoint.X) > 3 || Math.Abs(e.Y - startPoint.Y) > 3)
                    isMove = true;

                textBox1.Text = "" + Cursor.Position;
            }
        }

        

        private void displayTP_MouseMove_1(object sender, MouseEventArgs e)
        {
            textBox1.Text = ""+ PointToClient(Cursor.Position);
        }

        
    }
}
