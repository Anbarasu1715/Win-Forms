using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurnOut
{
    public partial class Form1 : Form
    {

        int originalLocationX;

        public Form1()
        {
            InitializeComponent();
            originalLocationX = scoreCardLabel.Location.X;
        }

        private void controlPanel_Resize(object sender, EventArgs e)
        {
            
        }

        private void mainPanel_Resize(object sender, EventArgs e)
        {
            
        }

        private void scoreCardLabel_TextChanged(object sender, EventArgs e)
        {
            double newX = originalLocationX;
            newX = originalLocationX-(scoreCardLabel.Text.Length*5);
            scoreCardLabel.Location = new Point((int)newX,scoreCardLabel.Location.Y);
        }
    }
}
