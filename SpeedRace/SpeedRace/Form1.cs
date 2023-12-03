using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedRace
{
    public partial class Form1 : Form
    {

        private int carXCordinate =50;
        private int carCount = 0;
        private List<Button> cars = new List<Button>();
        private List<Rectangle> carDefaultPosition = new List<Rectangle>();
        private List<Color> carColors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Black };
        private List<int> carNum = new List<int> {1,2,3,4};
        private int colorIndex=0;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            this.ActiveControl = racingTrackPanel;
            racingTrackPanel.Focus();
            userControl11.OnControlClicked += UserControl11_OnControlClicked;
            userControl12.OnControlClicked += UserControl11_OnControlClicked;

        }  

        private void UserControl11_OnControlClicked(object sender, string e)
        {
            MessageBox.Show(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AutoScroll() {
            actionsTextBox.SelectionStart = actionsTextBox.Text.Length;
            actionsTextBox.ScrollToCaret();
        }
        
        
        private void addCarBtn_Click(object sender, EventArgs e)
        {
            if (carCount < 4)
            {
                Button button = new Button
                {
                    Location = new System.Drawing.Point((racingTrackPanel.Location.X) + carXCordinate, racingTrackPanel.Location.Y + 630),
                    Size = new System.Drawing.Size(65, 70),
                    BackColor = carColors[colorIndex],
                    ForeColor = Color.White,
                    Text = carNum[colorIndex++] + "",
                    Font = new Font(Font,FontStyle.Bold)
                };
                carDefaultPosition.Add(new Rectangle(button.Location, button.Size));    
                cars.Add(button);
                racingTrackPanel.Controls.Add(button);
                carXCordinate += 120;
                carCount++;
            }
            else {
                msg msgBox = new msg();
                msgBox.Show();
            }
            racingTrackPanel.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle racingtrack = new Rectangle(racingTrackPanel.Location.X, racingTrackPanel.Location.Y, racingTrackPanel.Width, racingTrackPanel.Height);
        }

        

        private Button selectedCar;

        private void scoreCardBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad1)
            {
                actionsTextBox.Text = cars[0]+"";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void scoreCardBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                if (cars.Count > 0)
                    selectedCar = cars[0];
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                if (cars.Count > 1)
                    selectedCar = cars[1];
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                if (cars.Count > 2)
                    selectedCar = cars[2];
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                if (cars.Count > 3)
                    selectedCar = cars[3];
            }
            else if (e.KeyCode == Keys.Up && selectedCar != null)
            {
                bool movable = true;
                if (selectedCar.Location.Y > 0)
                {
                    foreach (Button car in cars) {
                        if (car.Location.Y == selectedCar.Location.Y - 70 && car.Location.X==selectedCar.Location.X)
                            movable = false;
                    }
                    if (movable)
                    {
                        selectedCar.Top -= 70;
                        actionsTextBox.Text += "\n   Car"+selectedCar.Text+" -> Moved Forward";
                        AutoScroll();
                    }
                    else
                    {
                        WarningLabel.Text = "Car" + selectedCar.Text + " -> Crashed";
                    }
                }
                //actionsTextBox.Text = selectedCar.Location.X + "  " + selectedCar.Location.Y;
            }
            else if (e.KeyCode == Keys.Left && selectedCar != null)
            {
                bool movable = true;
                if (selectedCar.Location.X > 50)
                {
                    foreach (Button car in cars)
                    {
                        if (car.Location.X==selectedCar.Location.X-120 && car.Location.Y==selectedCar.Location.Y)
                            movable = false;
                    }
                    if (movable)
                    {
                        selectedCar.Left -= 120;
                        actionsTextBox.Text += "\n   Car" + selectedCar.Text + "-> Moved Left";
                        AutoScroll();
                    }
                    else {
                        WarningLabel.Text = "Car" + selectedCar.Text + " -> Crashed";
                    }
                }
                //actionsTextBox.Text = selectedCar.Location.X + "  " + selectedCar.Location.Y;
            }
            else if (e.KeyCode == Keys.Right && selectedCar != null)
            {
                if (selectedCar.Location.X < 410)
                {
                    bool movable = true;
                    foreach (Button car in cars)
                    {
                        if (car.Location.X == selectedCar.Location.X + 120 && car.Location.Y == selectedCar.Location.Y)
                            movable = false;
                    }
                    if (movable)
                    {
                        selectedCar.Left += 120;
                        actionsTextBox.Text += "\n   Car" + selectedCar.Text + "-> Moved Right";
                        AutoScroll();
                    }
                    else
                    {
                        WarningLabel.Text = "Car" + selectedCar.Text + " -> Crashed";
                    }
                }
                //actionsTextBox.Text = selectedCar.Location.X + "  " + selectedCar.Location.Y;
            }
            else if (e.KeyCode == Keys.Down && selectedCar != null)
            {
                if (selectedCar.Location.Y < 630)
                {
                    bool movable = true;
                    foreach (Button car in cars)
                    {
                        if (car.Location.Y == selectedCar.Location.Y + 70 && car.Location.X == selectedCar.Location.X)
                            movable = false;
                    }
                    if (movable)
                    {
                        selectedCar.Top += 70;
                        actionsTextBox.Text += "\n   Car" + selectedCar.Text + "-> Moved Down";
                        AutoScroll();
                    }
                    else
                    {
                        WarningLabel.Text = "Car" + selectedCar.Text + " -> Crashed";
                    }
                }
                //actionsTextBox.Text = selectedCar.Location.X + "  " + selectedCar.Location.Y;
            }
        }

        private void racingTrackPanel_Click(object sender, EventArgs e)
        {
            racingTrackPanel.Focus();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (i < carDefaultPosition.Count)
                {
                    cars[i].Location = carDefaultPosition[i].Location;
                }
            }
        }

        private void racingTrackPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics line = e.Graphics;
            Pen pen = new Pen(Color.White,3);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            line.DrawLine(pen, 20, 0, 20, 730);
            line.DrawLine(pen,145,0,145,730);
            line.DrawLine(pen, 145+120, 0, 145+120, 730);
            line.DrawLine(pen, 145+240, 0, 145+240, 730);
            line.DrawLine(pen, 145+360, 0, 145+360, 730);
            pen.Dispose();
            line.Dispose();
        }
    }
}
