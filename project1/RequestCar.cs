using System.Xml.Linq;
using System.Drawing;
using System.Drawing.Imaging;

namespace project1
{
    public partial class RequestCar : Form
    {
        public static string Location = "";
        public static string Destanation = "";
        public Vehicle_Manager manager;

        public RequestCar(Vehicle_Manager manager)
        {
            this.manager = manager;
            if (Opts.YourLocation == true){
                enterLocation.Text="Your Location";

            }
            InitializeComponent();

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserData UserData = new UserData(manager);
            UserData.Show();
            this.Hide();
        }



        private void RequestCar_Load(object sender, EventArgs e)
        {

            btnUser.Text = UserData.fname;
        }


        private void Request_Click(object sender, EventArgs e)
        {   
            Location = enterLocation.Text;
            Destanation = enterDestanation.Text;

            using (Form dialog = new Form())
            {
                dialog.Text = "Choose a Number";
                dialog.ClientSize = new Size(200, 120);

                NumericUpDown num = new NumericUpDown()
                {
                    Left = 20,
                    Top = 20,
                    Minimum = 0,
                    Maximum = 100,
                    Value = 10
                };

                Button okBtn = new Button()
                {
                    Text = "OK",
                    Left = 20,
                    Top = 60,
                    DialogResult = DialogResult.OK
                };

                dialog.Controls.Add(num);
                dialog.Controls.Add(okBtn);
                dialog.AcceptButton = okBtn;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"You selected: {num.Value}");
                }
            }

            Waiting Waiting = new Waiting(manager);
            Waiting.Show();
            this.Hide();
        }

        private void enterLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterDestanation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}