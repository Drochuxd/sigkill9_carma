using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace project1
{
    public partial class Opts : Form
    {
        
        public static bool VoiceAssist = false;
        public static bool DoorLight = false;
        public static bool Ramp = false;
        public static bool YourLocation = false;
        public static bool checkBox = false;

        public Opts()
        {
            InitializeComponent();
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
    }
}
