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

        //private int heightCount = 1;
        //private int EndPoint = 0;
        //private int startPoint = 0;
        //private List<shapeUC> shapes = new List<shapeUC>();

        public int shapeCount = 0;
        public int width = 0;
        public int height = 0;
        public int ctr = 0;
        public int Srow = 0;
        public int Scol = 0;
        public int shapeWidth = 0;
        public int rowCount = 0;
        public List<Control> shapeList = new List<Control>();

        private Size formSize;
        private Rectangle recMainPanel;
        private Rectangle recDisplaypanel;
        private Rectangle recControlPanel;
        private Rectangle recBtnPanel1;
        private Rectangle recBtnPanel2;
        private Rectangle recAddBtn;
        private Rectangle recRemBtn;
        private Rectangle recWidthTB;
        private Rectangle recWLbl;
        



        //private enum colors
        //{
        //    Red,
        //    Green,
        //    Blue,
        //    Yellow,
        //    Purple,
        //    Orange,
        //    Pink,
        //    Gray
        //}

        enum Colors
        {
            Green,
            Yellow,
            Red,
            Blue,
            Black
        }


        public Form1()
        {
            InitializeComponent();
            formSize = this.Size;
            recMainPanel = new Rectangle(mainPanel.Location,mainPanel.Size);
            recDisplaypanel = new Rectangle(displayPanel.Location,displayPanel.Size);
            recControlPanel = new Rectangle(controlPanel.Location,controlPanel.Size);
            recBtnPanel1 = new Rectangle(addBtnPanel.Location,addBtnPanel.Size);
            recBtnPanel2 = new Rectangle(removeBtnPanel.Location,removeBtnPanel.Size);
            recAddBtn = new Rectangle(addBtn.Location,addBtn.Size);
            recRemBtn = new Rectangle(removeBtn.Location,removeBtn.Size);
            recWidthTB = new Rectangle(widthTB.Location,widthTB.Size);
            recWLbl = new Rectangle(wLbl.Location,wLbl.Size);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(mainPanel,recMainPanel);
            resizeControl(displayPanel, recDisplaypanel);
            resizeControl(controlPanel, recControlPanel);
            resizeControl(addBtnPanel, recBtnPanel1);
            resizeControl(removeBtnPanel, recBtnPanel2);
            resizeControl(addBtn, recAddBtn);
            resizeControl(removeBtn, recRemBtn);
            resizeControl(widthTB, recWidthTB);
            resizeControl(wLbl,recWLbl);
        }

        private void resizeControl(Control control, Rectangle rec)
        {
            float XRatio = (float)this.Size.Width /(float) formSize.Width;
            float YRatio = (float)this.Size.Height / (float)formSize.Height;

            int newX = (int)(rec.X * XRatio);
            int newY = (int)(rec.Y*YRatio);

            int newWidth = (int)(rec.Width*XRatio);
            int newHeight = (int)(rec.Height*YRatio);

            control.Location = new System.Drawing.Point(newX,newY);
            control.Size = new System.Drawing.Size(newWidth,newHeight);
        }

        private void resizeControl(Rectangle control, Rectangle rec) {
            float XRatio = (float)this.Size.Width / (float)formSize.Width;
            float YRatio = (float)this.Size.Height / (float)formSize.Height;

            int newX = (int)(rec.X * XRatio);
            int newY = (int)(rec.Y * YRatio);

            int newWidth = (int)(rec.Width * XRatio);
            int newHeight = (int)(rec.Height * YRatio);

            control.Location = new System.Drawing.Point(newX, newY);
            control.Size = new System.Drawing.Size(newWidth, newHeight);
        }

        //private Color GetRandomColor()
        //{

        //    int randomNumber = new Random().Next(Enum.GetValues(typeof(colors)).Length);

        //    switch (randomNumber)
        //    {
        //        case 0:
        //            return Color.Red;
        //        case 1:
        //            return Color.Green;
        //        case 2:
        //            return Color.Blue;
        //        case 3:
        //            return Color.Yellow;
        //        case 4:
        //            return Color.Purple;
        //        case 5:
        //            return Color.Orange;
        //        case 6:
        //            return Color.Pink;
        //        case 7:
        //            return Color.Gray;
        //        default:
        //            return Color.Black; 
        //    }
        //}



        //private void Createshape(shapeUC newShape) {
        //    int newX = 0, newY = 0;
        //    displayPanel.Controls.Add(newShape);

        //    if(shapes.Count==1)
        //        shapes[0].Location = new System.Drawing.Point(0, 0);

        //    if (shapes.Count > 1)
        //    {
        //        if (displayPanel.Width - (shapes[shapes.Count - 2].Location.X + shapes[shapes.Count - 2].Width) >= shapes[shapes.Count - 1].Width)
        //        { 
        //            newX = shapes[shapes.Count - 2].Location.X + shapes[shapes.Count - 2].Width;
        //            newY = shapes[shapes.Count - 2].Location.Y;
        //            EndPoint++;
        //        }
        //        else
        //        {
        //            heightCount++;

        //            shapes[startPoint].Location = new System.Drawing.Point((displayPanel.Width - (shapes[EndPoint].Location.X+ shapes[EndPoint].Width)) / 2, shapes[startPoint].Location.Y);
        //            warnLbl.Text= shapes[startPoint].Location.X+"";
        //            startPoint = shapes.Count - 1;
        //            newX = 0;
        //            newY = shapes[shapes.Count - 2].Location.Y + (shapes[shapes.Count - 2].Height) / heightCount;
        //            EndPoint = 0;
        //        }

        //        shapes[shapes.Count - 1].Location = new System.Drawing.Point(newX, newY);
        //    }

        //    shapes[0].Height = displayPanel.Height / heightCount;

        //    for (int i = 1; i < shapes.Count; i++) {

        //        if (displayPanel.Width - (shapes[i-1].Location.X + shapes[i - 1].Width)  >= shapes[i].Width)
        //        {
        //            newX = shapes[i - 1].Location.X + shapes[i - 1].Width;
        //            newY = shapes[i - 1].Location.Y;
        //        }
        //        else {
        //            newX = shapes[i].Location.X;
        //            newY = shapes[i - 1].Location.Y + (shapes[i - 1].Height);
        //        }
        //        shapes[i].Height = displayPanel.Height / heightCount;
        //        shapes[i].Location = new System.Drawing.Point(newX, newY);
        //    }

        //}

        //private void addBtn_Click(object sender, EventArgs e)
        //{
        //    int width=0;

        //    if (widthTB.Text.Length < 1)
        //        warnLbl.Text = "Width is Empty";
        //    else {
        //        warnLbl.Text = "";
        //        width = int.Parse(widthTB.Text);
        //        //widthTB.Text = "";
        //        if (width>634) {
        //            warnLbl.Text ="Width limit out of bounds";
        //        }
        //        else {
        //            shapeUC newShape = new shapeUC();
        //            newShape.Width = width;
        //            newShape.BackColor = Color.Green;
        //            newShape.BackColor = GetRandomColor();
        //            shapes.Add(newShape);
        //            Createshape(newShape);
        //        }
        //    }
        //}


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (widthTB.Text == "")
            {
                int row = shapeCount / 3 + 1;

                int col = shapeCount % 3;

                width = displayPanel.Width / 3;


                height = displayPanel.Height / row;


                int Srow = -height;
                int Scol = 0;

                shapeUC shape = new shapeUC();
                displayPanel.Controls.Add(shape);

                shape.BackColor = Color.FromName(((Colors)(ctr++ % 5)).ToString());


                //adding to collection
                shapeList.Add(shape);

                int i;
                for (i = 0; i < shapeList.Count - col - 1; i++)
                {
                    if (i % 3 == 0)
                    {
                        Srow = Srow + height;
                        Scol = 0;
                    }

                    shapeList[i].Location = new Point(Scol, Srow);
                    shapeList[i].Size = new Size(width, height);
                    Scol = Scol + width;
                }
                Srow = Srow + height;
                height = displayPanel.Height / row;
                Scol = 0;

                if (shapeCount % 3 == 0)
                {
                    if (widthTB.Text == "") width = displayPanel.Width;
                }
                else if (shapeCount % 3 == 1)
                {
                    if (widthTB.Text == "") width = displayPanel.Width / 2;
                }
                else
                {
                    if (widthTB.Text == "") width = displayPanel.Width / 3;
                }

                //adding the remaining button 
                for (; i < shapeList.Count(); i++)
                {
                    shapeList[i].Location = new Point(Scol, Srow);
                    shapeList[i].Size = new Size(width, height);
                    Scol = Scol + width;
                }

                shapeCount++;
            }
            else
            {

                
                width = Convert.ToInt32(widthTB.Text);
                if (width >= displayPanel.Width)
                {
                    MessageBox.Show("Enter smaller width");
                    return;
                }
                shapeUC Shape = new shapeUC();
                displayPanel.Controls.Add(Shape);
                Shape.Size = new System.Drawing.Size(width, displayPanel.Height);
                Shape.BackColor = Color.FromName(((Colors)(ctr++ % 5)).ToString());

                shapeList.Add(Shape);
                int RowCount = GetRowCount();
                UpdateLocation(RowCount);
            }


        }
        private void UpdateLocation(int rowCount)
        {
            int RowHeight = displayPanel.Height / rowCount, RemainingWidth = displayPanel.Width;
            int X = 0, Y = 0, Si = 0, Ei = 0;
            for (int ctr = 0; ctr < shapeList.Count; ctr++)
            {
                if (shapeList[ctr].Width <= RemainingWidth)
                {

                    shapeList[ctr].Location = new Point(X, Y);
                    shapeList[ctr].Size = new Size(shapeList[ctr].Width, RowHeight);


                    X += shapeList[ctr].Width; RemainingWidth -= shapeList[ctr].Width;

                    Ei++;
                }
                else
                {
                    CentrePrevRow(Si, Ei, RemainingWidth / 2);
                    RemainingWidth = displayPanel.Width;
                    X = 0; Y += RowHeight; Si = Ei = ctr;
                    ctr--;
                }
            }
        }

        private void CentrePrevRow(int Si, int Ei, int stepWidth)
        {
            for (int ctr = Si; ctr <= Ei; ctr++)
            {

                shapeList[ctr].Location = new Point(shapeList[ctr].Location.X + stepWidth, shapeList[ctr].Location.Y);

            }
        }

        private int GetRowCount()
        {
            int RemainingWidth = displayPanel.Width, RowCount = 1;
            for (int ctr = 0; ctr < shapeList.Count; ctr++)
            {
                if (shapeList[ctr].Width <= RemainingWidth)
                {
                    RemainingWidth -= shapeList[ctr].Width;
                }
                else
                {
                    RemainingWidth = displayPanel.Width;
                    RowCount++;
                    ctr--;
                }
            }

            return RowCount;
        }


        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
