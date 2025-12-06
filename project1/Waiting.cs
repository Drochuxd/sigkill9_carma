using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Waiting : Form
    {
        public Waiting()
        {
            InitializeComponent();
            locationLabel.Text = RequestCar.Location;
            destinationLabel.Text = RequestCar.Destanation;
            distanceLabel.Text = 2 + " miles";
        }

        private void Waiting_Load(object sender, EventArgs e)
        {

        }

        private void locationLabel_Click(object sender, EventArgs e)
        {

        }

        private void destinationLabel_Click(object sender, EventArgs e)
        {

        }

        private void distanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            RequestCar RequestCar = new RequestCar();
            RequestCar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Traveling Traveling = new Traveling(); 
            Traveling.Show(); 
            this.Hide();
        }
    }
}
