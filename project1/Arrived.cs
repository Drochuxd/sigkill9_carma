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
    public partial class Arrived : Form
    {
        public Vehicle_Manager manager;
        public Arrived(Vehicle_Manager mgr)
        {
            this.manager = mgr;
            InitializeComponent();
        }

        private void Arrived_Load(object sender, EventArgs e)
        {

        }
    }
}
