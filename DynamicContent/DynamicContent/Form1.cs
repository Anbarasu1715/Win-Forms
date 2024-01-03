using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicContent
{
    public partial class Form1 : Form
    {

        private int heightCount=1;
        private List<shapeUC> shapes = new List<shapeUC>();

        private enum colors {
            Red,
            Green,
            Blue,
            Yellow,
            Purple,
            Orange,
            Pink,
            Gray
        }

        public Form1()
        {
            InitializeComponent();
        }

        private Color GetRandomColor()
        {

            int randomNumber = new Random().Next(Enum.GetValues(typeof(colors)).Length);

            switch (randomNumber)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.Green;
                case 2:
                    return Color.Blue;
                case 3:
                    return Color.Yellow;
                case 4:
                    return Color.Purple;
                case 5:
                    return Color.Orange;
                case 6:
                    return Color.Pink;
                case 7:
                    return Color.Gray;
                default:
                    return Color.Black; // Default color if needed
            }
        }

       

        private void Createshape(shapeUC newShape) {
            int newX = 0, newY = 0;
            displayPanel.Controls.Add(newShape);
            
            shapes[0].Location = new System.Drawing.Point(0,0);

            if (shapes.Count > 1)
            {
                if (displayPanel.Width - (shapes[shapes.Count - 2].Location.X + shapes[shapes.Count - 2].Width) >= shapes[shapes.Count - 1].Width)
                {
                    newX = shapes[shapes.Count - 2].Location.X + shapes[shapes.Count - 2].Width;
                    newY = shapes[shapes.Count - 2].Location.Y;
                }
                else
                {
                    heightCount++;
                    newX = 0;
                    newY = shapes[shapes.Count - 2].Location.Y + (shapes[shapes.Count - 2].Height) / heightCount;
                }

                shapes[shapes.Count - 1].Location = new System.Drawing.Point(newX, newY);
            }

            shapes[0].Height = displayPanel.Height / heightCount;

            for (int i = 1; i < shapes.Count; i++) {

                if (displayPanel.Width - (shapes[i-1].Location.X + shapes[i - 1].Width)  >= shapes[i].Width)
                {
                    newX = shapes[i - 1].Location.X + shapes[i - 1].Width;
                    newY = shapes[i - 1].Location.Y;
                }
                else {
                    newX = 0;
                    newY = shapes[i - 1].Location.Y + (shapes[i - 1].Height);
                }
                shapes[i].Height = displayPanel.Height / heightCount;
                shapes[i].Location = new System.Drawing.Point(newX, newY);
            }

            //for (int i = 0; i < shapes.Count; i++)
            //{
            //    shapes[i].Height = displayPanel.Height / heightCount;
            //}
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int width=0;
            
            if (widthTB.Text.Length < 1)
                warnLbl.Text = "Width is Empty ";
            else {
                warnLbl.Text = "";
                width = int.Parse(widthTB.Text);
                //widthTB.Text = "";
                if (width>634) {
                    warnLbl.Text ="Width limit out of bounds";
                }
                else {
                    shapeUC newShape = new shapeUC();
                    newShape.Width = width;
                    newShape.BackColor = Color.Green;
                    newShape.BackColor = GetRandomColor();
                    shapes.Add(newShape);
                    Createshape(newShape);
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
