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
    public partial class Traveling : Form
    {
        public Vehicle_Manager manager;
        public Car currentCar;
        public int numSeats;
        public HeatedSeat selectedSeat;

        public Traveling(Vehicle_Manager mgr)
        {
            InitializeComponent();
            manager = mgr;
            currentCar = manager.vehicle_list[0];
            numSeats = currentCar.HeatedSeats.Count;
            for (int i = 0; i < this.numSeats; i++)
            {
                comboBox1.Items.Add("Seat " + (i + 1));
            }
            comboBox1.SelectedIndex = 0;
            selectedSeat = currentCar.HeatedSeats[comboBox1.SelectedIndex];
            numericUpDown1.Value = selectedSeat.Seat_Temperature;
        }

        private void Traveling_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSeat = currentCar.HeatedSeats[comboBox1.SelectedIndex];
            numericUpDown1.Value = selectedSeat.Seat_Temperature;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {   
            selectedSeat.set_seat_temperature((int)numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String on = "Off";
            selectedSeat.seat_toggle();

            if (selectedSeat.Seat_On)
                on = "on";

            MessageBox.Show($"seat{currentCar.HeatedSeats[comboBox1.SelectedIndex]} is {on}");
        }
    }
}
