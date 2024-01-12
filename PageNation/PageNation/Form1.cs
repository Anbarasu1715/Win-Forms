using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageNation
{
    public partial class Form1 : Form
    {

        private Button newBtn;
        private List<Button> buttons = new List<Button>();
        private int btnIndex=-1;
        private int pointCount = 0;
        private int previewCount;
        private int totalCount;
        private bool startIsPresent = false, endIspresent = false;
        private Button startBtn, endBtn;

        //private List<PictureShop> picData = new List<PictureShop>();
        private Dictionary<int, PictureShop> picData = new Dictionary<int, PictureShop>();
        private List<string> pics = new List<string>();

        private delegate void Buttonclick(Object sender,int n);
        private event Buttonclick onButtonClick;

        public Form1()
        {
            InitializeComponent();
            createBtn.Click += createButtons;
            onButtonClick += showBtnName;

            pics.Add("D:/pageiNation/pic1.jpg");
            pics.Add("D:/pageiNation/pic2.jpg");
            pics.Add("D:/pageiNation/pic3.jpg");
            pics.Add("D:/pageiNation/pic4.jpg");
            pics.Add("D:/pageiNation/pic5.jpg");
        }

        public enum CustomColors
        {
            Red,
            Yellow,
            Green,
            Blue,
            Purple,
            White,
            Orange,
            SpringGreen,
        }

        public Color GetColor(int index)
        {
            CustomColors customColor = (CustomColors)index;

            switch (customColor)
            {
                case CustomColors.Red:
                    return Color.Red;
                case CustomColors.Green:
                    return Color.Green;
                case CustomColors.Blue:
                    return Color.Blue;
                case CustomColors.Yellow:
                    return Color.Yellow;
                case CustomColors.Purple:
                    return Color.Purple;
                case CustomColors.Orange:
                    return Color.Orange;
                case CustomColors.SpringGreen:
                    return Color.SpringGreen;
                case CustomColors.White:
                    return Color.White;
                default:
                    return Color.Tomato; 
            }
        }


        private void clearControls() {
            previewpanel.Controls.Clear();
            buttons.Clear();
            btnIndex = -1;
            pointCount = 0;
            //foreach (Control c in previewpanel.Controls) {
            //    previewpanel.Controls.Remove(c);
            //}
        }

        private void indexBtnClick(Object sender,EventArgs e) {
            if ((sender as Button).Name == "startBtn")
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].Text = (i + 1) + "";
                }
                pointCount = 1;
                btnIndex = 0;
                if (startIsPresent)
                {
                    previewpanel.Controls.Remove(startBtn);
                    startIsPresent = false;
                }
                endBtn.Visible = true;

                buttons[0].Focus();
                picfocus();
            }
            else {
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].Text = (totalCount-previewCount+i+1) + "";
                }
                pointCount = totalCount;
                btnIndex = buttons.Count-1;
                endBtn.Visible = false;
                if (!startIsPresent)
                {
                    previewpanel.Controls.Add(startBtn);
                    startIsPresent = true;
                }
                buttons[buttons.Count-1].Focus();
                picfocus();
            }
        }

        private void showBtnName(Object sender, int n) {
            showLbl.Text = "Current Page Point is " +n;
        }

        private void btnClick(Object sender, EventArgs e) {
            if (int.TryParse((sender as Button)?.Text, out int result))
            {
                onButtonClick?.Invoke(sender, result);
                picfocus();
            }
            else
                showLbl.Text = "Not Pointing to Index";

            for (int i=0;i<buttons.Count;i++) {
                if ((sender as Button).Text==buttons[i].Text) {
                    btnIndex = i;
                }
            }
            pointCount = int.Parse((sender as Button).Text);
        }



        private void createButtons(Object sender,EventArgs e) {
            startIsPresent = false;
            clearControls();
            previewCount = int.Parse(previewTB.Text);
            totalCount = int.Parse(totalTB.Text);

            for (int i=0;i<totalCount;i++) {
                PictureShop shop = new PictureShop();
                shop.id = i + 1;
                shop.Location = pics[i % 5];
                picData[i + 1] = shop;
                picData[i + 1] = shop;
            }


            int width = 65;
            int height = 35;
            int x =(previewpanel.Width-((previewCount*width)+(previewCount-1)*5))/2; 
            int y = 30;

            if (previewCount <= 10 && previewCount > 0 && previewCount<=totalCount) {
                warnlbl.Text = "";
                if (totalCount <= 10000000)
                {
                    for (int i = 0; i < previewCount; i++)
                    {
                        newBtn = new Button()
                        {
                            Text = (i + 1) + "",
                            BackColor = GetColor(i % 8),
                            Location = new Point(x, y),
                            Size = new Size(width, height)
                        };
                        newBtn.Click += btnClick;
                        x += width + 5;
                        previewpanel.Controls.Add(newBtn);
                        buttons.Add(newBtn);
                    }
                    

                    endBtn = new Button()
                    {
                        Text = "...",
                        BackColor = GetColor(9),
                        Location = new Point(x, y),
                        Size = new Size(width, height),
                        Name = "endBtn"
                    };

                    endBtn.Click += indexBtnClick;

                    int x1 = buttons[0].Location.X - 70;
                    int y1 = 30;
                    int width1 = 65;
                    int height1 = 35;
                    startBtn = new Button()
                    {
                        Text = "...",
                        BackColor = GetColor(9),
                        Location = new Point(x1, y1),
                        Size = new Size(width1, height1),
                        Name = "startBtn"
                    };
                    startBtn.Click += indexBtnClick;
                    if (totalCount > previewCount)
                    {
                        previewpanel.Controls.Add(endBtn);
                        //buttons.Add(newBtn);
                    }  

                }
                else if (previewCount > 2)
                {
                    //for (int i = 0; i < previewCount / 2; i++)
                    //{
                    //    newBtn = new Button()
                    //    {
                    //        Text = (i + 1) + "",
                    //        BackColor = GetColor(i % 9),
                    //        Location = new Point(x, y),
                    //        Size = new Size(width, height)
                    //    };
                    //    newBtn.Click += btnClick;
                    //    x += width + 5;
                    //    previewpanel.Controls.Add(newBtn);
                    //    buttons.Add(newBtn);
                    //}
                    //newBtn = new Button()
                    //{
                    //    Text = ".....",
                    //    BackColor = Color.White,
                    //    //ForeColor = Color.White,
                    //    Location = new Point(x, y),
                    //    Size = new Size(width, height)
                    //};
                    //newBtn.Click += btnClick;
                    //x += width + 5;
                    //previewpanel.Controls.Add(newBtn);
                    //buttons.Add(newBtn);
                    //for (int i = totalCount - (previewCount - ((previewCount / 2) + 1)); i < totalCount; i++)
                    //{
                    //    newBtn = new Button()
                    //    {
                    //        Text = (i + 1) + "",
                    //        BackColor = GetColor(i % 8),
                    //        Location = new Point(x, y),
                    //        Size = new Size(width, height)
                    //    };
                    //    newBtn.Click += btnClick;
                    //    x += width + 5;
                    //    previewpanel.Controls.Add(newBtn);
                    //    buttons.Add(newBtn);
                    //}


                    //if (int.Parse(buttons[0].Text)>1 && buttons.Count>0) {
                    //    buttons[0].Text = "...";
                    //    startIsPresent = true;
                    //}

                    //for (int i=0;i<previewCount-1;i++) {
                    //    newBtn = new Button()
                    //    {
                    //        Text = (i + 1) + "",
                    //        BackColor = GetColor(i % 9),
                    //        Location = new Point(x, y),
                    //        Size = new Size(width, height)
                    //    };
                    //    newBtn.Click += btnClick;
                    //    x += width + 5;
                    //    previewpanel.Controls.Add(newBtn);
                    //    buttons.Add(newBtn);
                    //}
                    //newBtn = new Button()
                    //{
                    //    Text = "...",
                    //    BackColor = GetColor(9),
                    //    Location = new Point(x, y),
                    //    Size = new Size(width, height)
                    //};
                    //previewpanel.Controls.Add(newBtn);
                    //buttons.Add(newBtn);
                }
                else {
                    warnlbl.Text = "Invalid Limit";
                }
            }
            else {
                warnlbl.Text= "Preview out of Limit";
            }
        }



        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (buttons.Count>0) {
                if (pointCount >= totalCount)
                {
                    buttons[buttons.Count - 1].Focus();
                    return;
                }
                btnIndex++;
                pointCount++;
                if (btnIndex >= 0 && btnIndex < buttons.Count) {
                    buttons[btnIndex].Focus();
                }
                
                
                else if (btnIndex >= buttons.Count && int.Parse(buttons[buttons.Count - 1].Text) + 1 <= totalCount) {

                    foreach (Button btn in buttons) {
                        btn.Text = (int.Parse(btn.Text) + 1) + "";
                    }
                    buttons[buttons.Count - 1].Focus();
                    btnIndex--;
                }
            }
            if (buttons.Count > 0 && int.Parse(buttons[0].Text) > 1 && !startIsPresent) {
                
                
                previewpanel.Controls.Add(startBtn);
                startIsPresent = true;
            }

            if (int.Parse(buttons[buttons.Count - 1].Text) == totalCount)
                endBtn.Visible = false;

            //else if (startIsPresent) {
            //    previewpanel.Controls.Remove(startBtn);
            //    startIsPresent = false;
            //}
            //previewTB.Text = "" + btnIndex;
            picfocus();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                if (pointCount <=1 )
                {
                    buttons[0].Focus();
                    return;
                    
                }
                btnIndex--;
                pointCount--;
                if (btnIndex >= 0 && btnIndex < buttons.Count)
                {
                    buttons[btnIndex].Focus();
                }
                else if (btnIndex<0 && int.Parse(buttons[0].Text)-1>0) {
                    foreach (Button btn in buttons)
                    {
                        btn.Text = (int.Parse(btn.Text) - 1) + "";
                    }
                    buttons[0].Focus();
                    btnIndex++;
                }
            }
            if (int.Parse(buttons[0].Text) ==1)
            {
                previewpanel.Controls.Remove(startBtn);
                startIsPresent = false ;
            }
            if (int.Parse(buttons[buttons.Count - 1].Text) != totalCount)
                endBtn.Visible = true;
            //previewTB.Text = "" + btnIndex;
            picfocus();
        }

        private void picfocus() {
            int id=0;
            pictureBox?.Image?.Dispose();
            foreach (Button btn in buttons) {
                if (btn.Focused) {
                    if (int.TryParse(btn.Text, out id)) ;
                }
            }
            showLbl.Text = "Current Page Point is " + id;
            pictureBox.Image = Image.FromFile(picData[id].Location);
        }
    }
}
