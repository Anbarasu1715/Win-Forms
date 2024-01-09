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
        public Form1()
        {
            InitializeComponent();

            foreach (Control control in mainPanel.Controls) {
                if (control is Button btn) {
                    
                }
            }

        }

        private void btns_Click(Object sender,EventArgs e) {
            Button btn = sender as Button;
            btn.BackColor = Color.Black;
        }

    }
}
