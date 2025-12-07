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

    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            UserData.fname = txtFirstName.Text;
            UserData.lname = txtLastName.Text;
            UserData.emailaddress = txtEmailAddress.Text;
            


            Opts Opts = new Opts(new Vehicle_Manager());
            Opts.Show();
            this.Hide();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}