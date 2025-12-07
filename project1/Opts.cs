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
    public partial class Opts : Form
    {
        public Vehicle_Manager manager;
        public static bool VoiceAssist = false;
        public static bool heatedSeats = false;
        public static bool DoorLight = false;
        public static bool Ramp = false;
        public static bool YourLocation = false;
        public static bool checkBox = false;

        public Opts(Vehicle_Manager mgr)
        {
            InitializeComponent();
            manager = mgr;
        }

        private void chkVoiceAssistance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVoiceAssistance.Checked)
            {
                MessageBox.Show("You have opted for Voice Assistance service.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VoiceAssist = true;
            }
            else
            {
                VoiceAssist = false;
            }
        }

        private void chkDoorLight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoorLight.Checked)
            {
                MessageBox.Show("You have opted for Door Light service.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                chkDoorLight.Checked = false;

            }
        }

        private void chkRamp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRamp.Checked)
            {
                MessageBox.Show("You have opted for Ramp service.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                chkRamp.Checked = false;
            }

        }

        private void chkYourLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYourLocation.Checked)
            {
                MessageBox.Show("You have opted for Your Location service.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                chkYourLocation.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("You have opted for Extra Time service.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            VoiceAssist = chkVoiceAssistance.Checked;
            DoorLight = chkDoorLight.Checked;
            Ramp = chkRamp.Checked;
            YourLocation = chkYourLocation.Checked;
            checkBox = checkBox1.Checked;

            RequestCar RequestCar = new RequestCar();
            RequestCar.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            VoiceAssist = chkVoiceAssistance.Checked;
            DoorLight = chkDoorLight.Checked;
            Ramp = chkRamp.Checked;
            YourLocation = chkYourLocation.Checked;
            checkBox = checkBox1.Checked;

            UserData UserData = new UserData();
            UserData.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            chkVoiceAssistance.CheckedChanged += chkVoiceAssistance_CheckedChanged;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lightsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void heatedSeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentCar == null || currentCar.HeatedSeats == null || currentCar.HeatedSeats.Count == 0)
            {
                MessageBox.Show("This car has no heated seats.");
                return;
            }

            // Clear any old seat items
            heatedSeatsToolStripMenuItem.DropDownItems.Clear();

            // One menu item per seat
            for (int i = 0; i < currentCar.HeatedSeats.Count; i++)
            {
                int seatIndex = i; // capture for lambda

                ToolStripMenuItem seatItem = new ToolStripMenuItem($"Seat {seatIndex + 1}");

                seatItem.Click += (s, args) =>
                {
                    HeatedSeat seat = currentCar.HeatedSeats[seatIndex];
                    ShowHeatedSeatDialog(seat, seatIndex + 1);
                };

                heatedSeatsToolStripMenuItem.DropDownItems.Add(seatItem);
            }
        }
        private void ShowHeatedSeatDialog(HeatedSeat seat, int seatNumber)
        {
            using (Form dialog = new Form())
            {
                dialog.Text = $"Seat {seatNumber} Settings";
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MinimizeBox = false;
                dialog.MaximizeBox = false;
                dialog.ClientSize = new Size(260, 150);

                // Label for temperature
                Label lblTemp = new Label()
                {
                    Left = 10,
                    Top = 20,
                    Text = "Temp (70–90):",
                    AutoSize = true
                };

                // TextBox for temperature
                TextBox txtTemp = new TextBox()
                {
                    Left = 120,
                    Top = 18,
                    Width = 100,
                    Text = seat.Seat_Temperature.ToString()
                };

                // Checkbox for On / Off
                CheckBox chkOn = new CheckBox()
                {
                    Left = 10,
                    Top = 55,
                    Text = "Seat On",
                    Checked = seat.Seat_On,
                    AutoSize = true
                };

                // OK and Cancel buttons
                Button btnOk = new Button()
                {
                    Text = "OK",
                    DialogResult = DialogResult.OK,
                    Left = 50,
                    Width = 75,
                    Top = 95
                };

                Button btnCancel = new Button()
                {
                    Text = "Cancel",
                    DialogResult = DialogResult.Cancel,
                    Left = 140,
                    Width = 75,
                    Top = 95
                };

                dialog.Controls.Add(lblTemp);
                dialog.Controls.Add(txtTemp);
                dialog.Controls.Add(chkOn);
                dialog.Controls.Add(btnOk);
                dialog.Controls.Add(btnCancel);

                dialog.AcceptButton = btnOk;
                dialog.CancelButton = btnCancel;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Try to parse the temperature
                    if (int.TryParse(txtTemp.Text, out int newTemp))
                    {
                        // Your HeatedSeat already checks range (70–90)
                        seat.set_seat_temperature(newTemp);
                    }
                    else
                    {
                        MessageBox.Show("Invalid temperature. Keeping previous value.");
                    }

                    // Update On / Off
                    if (chkOn.Checked != seat.Seat_On)
                    {
                        seat.seat_toggle();
                    }

                    MessageBox.Show(
                        $"Seat {seatNumber}: {(seat.Seat_On ? "ON" : "OFF")} at {seat.Seat_Temperature}°"
                    );
                }
            }
        }

        private void Opts_Load(object sender, EventArgs e)
        {

        }
    }
}

