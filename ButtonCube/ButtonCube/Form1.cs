using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCube
{
    public partial class Form1 : Form
    {

        private int ButtonCount=0;
        private int newX, newY;
        private List<Button> buttons = new List<Button>();

        public Form1()
        {
            newX = 0; newY=0;
            InitializeComponent();
        }


        //private void InitializeUserControl(int BtnLimit) {
            
        //    int width = containerUserControl.Width / ((BtnLimit>=3)?3: BtnLimit % 3);
        //    int height = ((BtnLimit/3)<1)?1:(BtnLimit/3)+1;
        //    if (BtnLimit % 3 == 0)
        //        height--;
        //    containerUserControl.Controls.Clear();
        //    newX = 0; newY = 0;

        //    int limit = BtnLimit-(BtnLimit%3);
        //    for (int i=1;i<=limit;i++) {
        //        Button newBtn = new Button
        //        {
        //            Location = new System.Drawing.Point(newX, newY),
        //            Size = new System.Drawing.Size(width,containerUserControl.Height/height),
        //            BackColor=Color.Black,
        //            Margin=new Padding(0,0,0,0)
        //        };
        //        containerUserControl.Controls.Add(newBtn);
        //        newX+=newBtn.Width;
        //        if (i % 3 == 0)
        //        {
        //            newY += newBtn.Height;
        //            newX = 0;
        //        }
        //    }
        //    if (BtnLimit - limit == 1) {
        //        Button newBtn = new Button
        //        {
        //            Location = new System.Drawing.Point(newX, newY),
        //            Size = new System.Drawing.Size(450, containerUserControl.Height / height),
        //            BackColor = Color.Black,
        //            Margin = new Padding(0, 0, 0, 0)
        //        };
        //        containerUserControl.Controls.Add(newBtn);
        //    }
        //    else if (BtnLimit-limit==2) {
        //        Button newBtn = new Button
        //        {
        //            Location = new System.Drawing.Point(newX, newY),
        //            Size = new System.Drawing.Size(450/2, containerUserControl.Height / height),
        //            BackColor = Color.Black,
        //            Margin = new Padding(0, 0, 0, 0)
        //        };
        //        containerUserControl.Controls.Add(newBtn);
        //        newBtn = new Button
        //        {
        //            Location = new System.Drawing.Point(newX+225, newY),
        //            Size = new System.Drawing.Size(450/2, containerUserControl.Height / height),
        //            BackColor = Color.Black,
        //            Margin = new Padding(0, 0, 0, 0)
        //        };
        //        containerUserControl.Controls.Add(newBtn);
        //    }
            
        //}


        private void InitializeUserControl( int BtnLimit)
        {
            int i = 0;
            int width = containerUserControl.Width / ((BtnLimit >= 3) ? 3 : BtnLimit % 3);
            int height = ((BtnLimit / 3) < 1) ? 1 : (BtnLimit / 3) + 1;
            if (BtnLimit % 3 == 0)
                height--;
            containerUserControl.Controls.Clear();
            newX = 0; newY = 0;

            int limit = BtnLimit - (BtnLimit % 3);
            for (i = 0; i < limit; i++)
            {
                buttons[i].Location = new System.Drawing.Point(newX, newY);
                buttons[i].Size = new System.Drawing.Size(width, containerUserControl.Height / height);
                
                
                containerUserControl.Controls.Add(buttons[i]);
                newX += buttons[i].Width;
                if (i % 3 == 2)
                {
                    newY += buttons[i].Height;
                    newX = 0;
                }
            }
            if (BtnLimit - limit == 1)
            {
                
                buttons[i].Location = new System.Drawing.Point(newX, newY);
                buttons[i].Size = new System.Drawing.Size(450, containerUserControl.Height / height);
                
                containerUserControl.Controls.Add(buttons[i]);
            }
            else if (BtnLimit - limit == 2)
            {
                buttons[i].Location = new System.Drawing.Point(newX, newY);
                buttons[i].Size = new System.Drawing.Size(450/2, containerUserControl.Height / height);
                
                containerUserControl.Controls.Add(buttons[i]);

                buttons[i].Location = new System.Drawing.Point(newX+225, newY);
                buttons[i].Size = new System.Drawing.Size(450/2, containerUserControl.Height / height);
               
                containerUserControl.Controls.Add(buttons[i]);
            }
        }

        private void AddButtonToPanel() {


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //displayLbl.Text = "";
            Button newBtn = new Button
            {
                BackColor = Color.Black,
                Margin = new Padding(0, 0, 0, 0)
            };
            buttons.Add(newBtn);

            ButtonCount++;
            //for (int i=buttons.Count;i<ButtonCount;i++) {
                
            //}
            InitializeUserControl(ButtonCount);
            //buttonClick(sender);
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            displayLbl.Text = ButtonCount+ "";
            //displayLbl.Text = "";
            ButtonCount--;
            if (ButtonCount > 0)
            {
                InitializeUserControl(ButtonCount);
                //buttonClick(sender);
                
            }
            else
            {
                containerUserControl.Controls.Clear();
                ButtonCount = 0;
            }
        }

        private void buttonClick(object sender) {
            if((sender as Button).Text=="+")
                displayLbl.Text ="New Button Added";
            else
                displayLbl.Text = "Button Removed";
        }
    }
}
