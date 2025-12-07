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
    public partial class OpenPage : Form
    {
        public OpenPage()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }

        private void register_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
            this.Hide();
        }

        private void OpenPage_Load(object sender, EventArgs e)
        {

        }
    }
}
