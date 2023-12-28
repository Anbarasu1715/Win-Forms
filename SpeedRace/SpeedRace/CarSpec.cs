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
    public partial class CarSpec : UserControl
    {

        private List<string> cars = new List<string>();
        private int carIndex = 0;
        public CarSpec()
        {
            InitializeComponent();
            cars.Add("Yellow -Resized.png");
            cars.Add("blue - Resized.png");
            cars.Add("violet - Resized.png");
            cars.Add("benz - Resized.png");
        }

        private void CarSpec_Load(object sender, EventArgs e)
        {
            CarImages.Image = Image.FromFile("C:\\Users\\anbar\\Downloads\\Car Images\\"+cars[carIndex++%cars.Count]);
        }

        private void CarImages_Click(object sender, EventArgs e)
        {

        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            CarImages.Image = Image.FromFile("C:\\Users\\anbar\\Downloads\\Car Images\\" + cars[carIndex++%cars.Count]);
        }

        private void textLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarImages.Image = Image.FromFile("C:\\Users\\anbar\\Downloads\\Car Images\\" + cars[carIndex>0?--carIndex%cars.Count:carIndex=cars.Count-1]);
        }
    }
}
