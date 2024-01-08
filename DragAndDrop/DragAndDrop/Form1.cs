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

        public Form1()
        {
            InitializeComponent();
            

            btn1.MouseDown+=MouseDown;
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


        
        private void MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            Point CurrentLocation = displayTP.PointToClient(btn.PointToScreen(new Point(0, 0)));

        }

        private void MouseDown(object sender, MouseEventArgs e) {
            startPoint = e.Location;
            (sender as Button).BringToFront();
        }

        private void MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                (sender as Button).Left += e.X - startPoint.X;
                (sender as Button).Top += e.Y - startPoint.Y;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }
    }
}
