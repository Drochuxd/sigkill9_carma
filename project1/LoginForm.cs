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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string id = txtUser.Text;
            string pass = txtPassword.Text;
            if (id == "admin" && pass == "admin")
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                RequestCar mainForm = new RequestCar();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid User ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginForm Login = new LoginForm();
                Login.Show();
                this.Hide();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            OpenPage OpenPage = new OpenPage();
            OpenPage.Show();
            this.Hide();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
