using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// remove me

namespace project1
{
    public partial class Traveling : Form
    {
        public Vehicle_Manager manager;
        public static Car currentCar;

        public Traveling(Vehicle_Manager mg)
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            currentCar = manager.vehicle_list[0];
        }

        private void Traveling_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numSeats = currentCar.HeatedSeats.Count;

            for (int i = 0; i < numSeats; i++)
            {
                comboBox1.Items.Add("Seat " + (i + 1));
            }

        }
    }
}
