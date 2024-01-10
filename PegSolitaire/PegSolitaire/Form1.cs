using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegSolitaire
{
    public partial class Form1 : Form
    {

        private List<Control> Buttons = new List<Control>();
        private Control selectedPeg;
        private Control selectedEmptyBox;
        private int pegRow,pegCol;
        private int boxRow, boxCol;
        private TableLayoutPanel pegPanel, boxPanel;

        public Form1()
        {
            InitializeComponent();

            pegsLbl.Text = "32";
            scoreLbl.Text = "0";

            foreach (Control control in TB1.Controls) {
                if (control is Button) {
                    control.Click += btns_Click;
                    Buttons.Add(control);
                    //textBox1.Text += "  " + control.Name + "   R:" + TB1.GetRow(control) + "    C:" + TB1.GetColumn(control) + Environment.NewLine;
                }
                else if (control is PictureBox) {
                    control.Click += emptyBoxClick;
                }
            }

            foreach (Control control in TB2.Controls)
            {
                if (control is Button)
                {
                    control.Click += btns_Click;
                    Buttons.Add(control);
                }
            }
            foreach (Control control in TB3.Controls)
            {
                if (control is Button)
                {
                    control.Click += btns_Click;
                    Buttons.Add(control);
                }
            }

            //TB3.Controls.Remove(btn20);

            //PictureBox pic = new PictureBox()
            //{
            //    Dock = DockStyle.Fill,
            //    BackColor = Color.SpringGreen
            //};
            //pic.Click += emptyBoxClick;

            //TB3.Controls.Add(pic,0,2);
        }

        private void btns_Click(Object sender,EventArgs e) {
            Button btn = sender as Button;
            foreach (Control btns in Buttons) {
                btns.BackColor = Color.White;
                //btns.Text = btns.Name;
            }
            btn.BackColor = Color.Black;
            selectedPeg = btn;
            Tuple<int, int, TableLayoutPanel> indices = getControlIndices(selectedPeg,selectedPeg.GetType());
            pegRow = indices.Item1;
            pegCol = indices.Item2;
            pegPanel = indices.Item3;
            //textBox1.Text = pegRow + "  " + pegCol;
        }

        private void emptyBoxClick(object sender,EventArgs e) {
            if (selectedPeg!=null) {
                selectedEmptyBox = sender as PictureBox;
                Tuple<int, int, TableLayoutPanel> indices = getControlIndices(selectedEmptyBox,selectedEmptyBox.GetType());
                boxRow = indices.Item1;
                boxCol = indices.Item2;
                boxPanel = indices.Item3;
                //textBox1.Text=boxRow+"  "+boxCol;

                if (IsValidMove())
                {
                    
                    UpdateBoard(pegPanel);
                    
                    selectedPeg = null;
                }
                else
                {
                    //MessageBox.Show("Invalid move!");
                }
            }
        }


        private bool IsValidMove()
        {
            if (pegPanel == boxPanel)
            {
                int rowDifference = Math.Abs(pegRow - boxRow);
                int colDifference = Math.Abs(pegCol - boxCol);

                return (rowDifference == 2 && colDifference == 0) || (rowDifference == 0 && colDifference == 2);
            }
            else if (pegPanel == TB1 && boxPanel == TB3 && boxCol == 1)//
            {
                int jumpedRow = pegRow;
                int jumpedCol = 0;
                UpdateBoard(jumpedRow, jumpedCol, pegPanel, boxPanel, TB1, false);

            }
            else if (pegPanel == TB3 && boxPanel == TB1 && pegCol == 1)
            {
                int jumpedRow = boxRow;
                int jumpedCol = 0;
                UpdateBoard(jumpedRow, jumpedCol, boxPanel, pegPanel);
            }
            else if (pegPanel == TB3 && boxPanel == TB1 && pegCol == 0) {
                int jumpedRow = pegRow;
                int jumpedCol = 1;
                UpdateBoard(jumpedRow, jumpedCol, boxPanel, pegPanel, 1);
            }
            else if (pegPanel==TB1 && boxPanel==TB3 && boxCol==0)
            {
                int jumpedRow = boxRow;
                int jumpedCol = 1;
                UpdateBoard(jumpedRow, jumpedCol, pegPanel, boxPanel, TB3, true);
            }
            else if (pegPanel == TB2 && boxPanel == TB1 && pegCol == 1)//
            {
                int jumpedRow = pegRow;
                int jumpedCol = 0;
                UpdateBoard(jumpedRow, jumpedCol, pegPanel, boxPanel, TB2, false);
            }
            else if (pegPanel == TB2 && boxPanel == TB1 && pegCol == 0)
            {
                int jumpedRow = boxRow;
                int jumpedCol = 2;
                UpdateBoard(jumpedRow, jumpedCol, boxPanel, pegPanel);
            }//6
            else if (pegPanel == TB1 && boxPanel == TB2 && boxCol == 0)
            {
                int jumpedRow = pegRow;
                int jumpedCol = 2;
                UpdateBoard(jumpedRow, jumpedCol, boxPanel, pegPanel, "hello");
            }
            else if (pegPanel == TB1 && boxPanel == TB2 && boxCol == 1) {//
                int jumpedRow = boxRow;
                int jumpedCol = 0;
                UpdateBoard(jumpedRow, jumpedCol, pegPanel, boxPanel, TB2, true);
            }
            

            return false;
        }

        //6
        private void UpdateBoard(int jumpedRow, int jumpedCol, TableLayoutPanel rp, TableLayoutPanel bp,string h)
        {


            Button jumpedPeg = GetButtonByIndices(jumpedRow, jumpedCol);

            bp.Controls.Remove(jumpedPeg);
            //textBox1.Text = pegPanel.Name + "";

            rp.Controls.Remove(selectedEmptyBox);


            rp.Controls.Add(selectedPeg, boxCol, boxRow);
            selectedPeg.BackColor = Color.White;
            selectedPeg.Dock = DockStyle.Fill;

            PictureBox pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;


            bp.Controls.Add(pic, jumpedCol, jumpedRow);
            pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;
            bp.Controls.Add(pic, pegCol, pegRow);



            int remainingPegs = int.Parse(pegsLbl.Text) - 1;
            int currentScore = int.Parse(scoreLbl.Text) + 1;

            pegsLbl.Text = remainingPegs.ToString();
            scoreLbl.Text = currentScore.ToString();


            if (remainingPegs == 1)
            {
                MessageBox.Show("Game Over! Your final score is: " + currentScore);

            }
        }

        //4
        private void UpdateBoard(int jumpedRow, int jumpedCol, TableLayoutPanel rp, TableLayoutPanel bp,TableLayoutPanel TB,bool flag)
        {


            Button jumpedPeg = GetButtonByIndices(jumpedRow, jumpedCol,TB);
            
            if(flag)
                bp.Controls.Remove(jumpedPeg);
            else
                rp.Controls.Remove(jumpedPeg);
           // textBox1.Text = pegPanel.Name + "";

            rp.Controls.Remove(selectedEmptyBox);
            ClearCell(bp, boxRow, boxCol);

            bp.Controls.Add(selectedPeg, boxCol, boxRow);
            selectedPeg.BackColor = Color.White;
            selectedPeg.Dock = DockStyle.Fill;

            PictureBox pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;

            if (flag)
                bp.Controls.Add(pic, jumpedCol, jumpedRow);
            else
                rp.Controls.Add(pic, jumpedCol, jumpedRow);
            pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;
            rp.Controls.Add(pic, pegCol, pegRow);



            int remainingPegs = int.Parse(pegsLbl.Text) - 1;
            int currentScore = int.Parse(scoreLbl.Text) + 1;

            pegsLbl.Text = remainingPegs.ToString();
            scoreLbl.Text = currentScore.ToString();


            if (remainingPegs == 1)
            {
                MessageBox.Show("Game Over! Your final score is: " + currentScore);

            }
        }



        //3
        private void UpdateBoard(int jumpedRow, int jumpedCol, TableLayoutPanel rp, TableLayoutPanel bp,int flag)
        {


            Button jumpedPeg = GetButtonByIndices(jumpedRow, jumpedCol,TB3);

            bp.Controls.Remove(jumpedPeg);
            //textBox1.Text = pegPanel.Name + "";

            bp.Controls.Remove(selectedEmptyBox);
            ClearCell(rp,boxRow,boxCol);

            rp.Controls.Add(selectedPeg, boxCol, boxRow);
            selectedPeg.BackColor = Color.White;
            selectedPeg.Dock = DockStyle.Fill;

            PictureBox pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;


            bp.Controls.Add(pic, jumpedCol, jumpedRow);
            pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;
            bp.Controls.Add(pic, pegCol, pegRow);



            int remainingPegs = int.Parse(pegsLbl.Text) - 1;
            int currentScore = int.Parse(scoreLbl.Text) + 1;

            pegsLbl.Text = remainingPegs.ToString();
            scoreLbl.Text = currentScore.ToString();


            if (remainingPegs == 1)
            {
                MessageBox.Show("Game Over! Your final score is: " + currentScore);

            }
        }

        //2
        private void UpdateBoard(int jumpedRow,int jumpedCol,TableLayoutPanel rp,TableLayoutPanel bp)
        {
            

            Button jumpedPeg = GetButtonByIndices(jumpedRow, jumpedCol);

            rp.Controls.Remove(jumpedPeg);
            //textBox1.Text = pegPanel.Name + "";

            rp.Controls.Remove(selectedEmptyBox);
            

            rp.Controls.Add(selectedPeg, boxCol, boxRow);
            selectedPeg.BackColor = Color.White;
            selectedPeg.Dock = DockStyle.Fill;

            PictureBox pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;


            rp.Controls.Add(pic, jumpedCol, jumpedRow);
            pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;
            bp.Controls.Add(pic, pegCol, pegRow);



            int remainingPegs = int.Parse(pegsLbl.Text) - 1;
            int currentScore = int.Parse(scoreLbl.Text) + 1;

            pegsLbl.Text = remainingPegs.ToString();
            scoreLbl.Text = currentScore.ToString();


            if (remainingPegs == 1)
            {
                MessageBox.Show("Game Over! Your final score is: " + currentScore);

            }
        }


        private void UpdateBoard(TableLayoutPanel panel)
        {
            int jumpedRow = (pegRow + boxRow) / 2;
            int jumpedCol = (pegCol + boxCol) / 2;

            Button jumpedPeg = GetButtonByIndices(jumpedRow, jumpedCol,panel);
            
            pegPanel.Controls.Remove(jumpedPeg);
            //textBox1.Text = pegPanel.Name + "";

            pegPanel.Controls.Remove(selectedEmptyBox);
            pegPanel.Controls.Add(selectedPeg,boxCol,boxRow);
            selectedPeg.BackColor = Color.White;
            selectedPeg.Dock = DockStyle.Fill;

            PictureBox pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;


            pegPanel.Controls.Add(pic, jumpedCol, jumpedRow);
            pic = new PictureBox()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue
            };
            pic.Click += emptyBoxClick;
            pegPanel.Controls.Add(pic, pegCol, pegRow);
            

            
            int remainingPegs = int.Parse(pegsLbl.Text) - 1;
            int currentScore = int.Parse(scoreLbl.Text) + 1;

            pegsLbl.Text = remainingPegs.ToString();
            scoreLbl.Text = currentScore.ToString();

            
            if (remainingPegs == 1)
            {
                MessageBox.Show("Game Over! Your final score is: " + currentScore);
                
            }
        }

        private Button GetButtonByIndices(int row, int col,TableLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Button && TB1.GetRow(control) == row && TB1.GetColumn(control) == col)
                {
                    return (Button)control;
                }
            }
            return null;
        }

        private Button GetButtonByIndices(int row, int col)
        {
            foreach (Control control in TB1.Controls)
            {
                if (control is Button && TB1.GetRow(control) == row && TB1.GetColumn(control) == col)
                {
                    return (Button)control;
                }
            }
            return null;
        }


        private void checkPegMatch() {
            
        }

        private Tuple<int, int, TableLayoutPanel> getControlIndices(object control,Type type) {
            foreach (Control c in TB1.Controls) {
                if (c.GetType()==type && c==control) {
                    int row = TB1.GetRow(c);
                    int col = TB1.GetColumn(c);
                    return new Tuple<int,int, TableLayoutPanel>(row,col,TB1);
                }
            }
            foreach (Control c in TB2.Controls)
            {
                if (c.GetType() == type && c == control)
                {
                    int row = TB1.GetRow(c);
                    int col = TB1.GetColumn(c);
                    return new Tuple<int, int, TableLayoutPanel>(row, col,TB2);
                }
            }
            foreach (Control c in TB3.Controls)
            {
                if (c.GetType() == type && c == control)
                {
                    int row = TB1.GetRow(c);
                    int col = TB1.GetColumn(c);
                    return new Tuple<int, int, TableLayoutPanel>(row, col,TB3);
                }
            }
            return new Tuple<int, int, TableLayoutPanel>(-1,-1,null);
        }

        private void ClearCell(TableLayoutPanel tableLayoutPanel, int row, int column)
        {
            
            Control controlToRemove = tableLayoutPanel.GetControlFromPosition(column, row);

            
            if (controlToRemove != null)
            {
                tableLayoutPanel.Controls.Remove(controlToRemove);
            }
        }

        private void TB1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {

        }
    }
}
