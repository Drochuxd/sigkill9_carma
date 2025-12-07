using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// remove me

namespace project1
{
    public partial class UserData : Form
    {
        public static string fname = "";
        public static string lname = "";
        public static string emailaddress = "";
        public Vehicle_Manager manager;

        public UserData()
        {
            InitializeComponent();
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            fName.Text = fname;
            lName.Text = lname;
            emailAddress.Text = emailaddress;

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {

            RequestCar RequestCar = new RequestCar();
            RequestCar.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            OpenPage OpenPage = new OpenPage();
            OpenPage.Show();
            this.Hide();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Opts Opts = new Opts(new Vehicle_Manager());
            Opts.Show();
            this.Hide();
        }
    }
}
