using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedRace
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private string displayName;

        public delegate void clickEvent(object sender, string A);

        public event clickEvent OnControlClicked ;

        public string name = "becca";

        public string DisplayName
        {
            get
            {
                return displayName;
            }
            set
            {
                if (value == null) return;
                displayName = value;
            }
        }


        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);
            OnControlClicked?.Invoke(this, DisplayName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             OnClick(e);
            OnControlClicked?.Invoke(this, name);

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
