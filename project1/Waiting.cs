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
        public Vehicle_Manager manager;
        public int person_count;

        public Waiting(Vehicle_Manager manager, int person_count)
        {
            this.manager = manager;
            this.person_count = person_count;
            InitializeComponent();
            locationLabel.Text = RequestCar.Location;
            destinationLabel.Text = RequestCar.Destanation;
            distanceLabel.Text = 2 + " miles";
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
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
            RequestCar RequestCar = new RequestCar(manager);
            RequestCar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"./Warning.wav");
            if (manager.vehicle_list[0].Car_Security_System.detect_people(this.person_count)) sp.Play();
            sp.PlaySync();
            Traveling Traveling = new Traveling(manager);
            Traveling.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
			System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"./Warning.wav");
			if (manager.vehicle_list[0].Car_Security_System.detect_people(this.person_count)) sp.Play();
			sp.PlaySync();
            MessageBox.Show("ok for if they wanted to continue seting personcount to detected people if not it locks the door and notifies the authoritys", "Audio Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Traveling Traveling = new Traveling(manager);
            Traveling.Show();
            this.Hide();
        }
    }
}
