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
            int person_count = 1;

            using (Form dialog = new Form())
            {
                dialog.Text = "Request:";
                dialog.ClientSize = new Size(200, 120);

                Label lbl = new Label()
                {
                    Left = 20,
                    Top = 15,
                    Text = "How many Passengers",
                    AutoSize = true
                };

                NumericUpDown num = new NumericUpDown()
                {
                    Left = 20,
                    Top = 40,
                    Minimum = 0,
                    Maximum = 100,
                    Value = 10
                };

                Button okBtn = new Button()
                {
                    Text = "OK",
                    Left = 20,
                    Top = 70,
                    DialogResult = DialogResult.OK
                };

                dialog.Controls.Add(lbl);
                dialog.Controls.Add(num);
                dialog.Controls.Add(okBtn);
                dialog.AcceptButton = okBtn;
                dialog.Controls.Add(okBtn);
                dialog.AcceptButton = okBtn;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    person_count = (int)num.Value;
                    MessageBox.Show($"Ride Request for {num.Value} people submitted!");
                }
            }

            Waiting Waiting = new Waiting(manager, person_count);
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