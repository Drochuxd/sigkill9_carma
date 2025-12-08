namespace project1
{
    partial class Opts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnUser = new Button();
            button1 = new Button();
            chkYourLocation = new CheckBox();
            chkRamp = new CheckBox();
            chkDoorLight = new CheckBox();
            chkVoiceAssistance = new CheckBox();
            menuStrip1 = new MenuStrip();
            tempratureToolStripMenuItem = new ToolStripMenuItem();
            aCTempratureToolStripMenuItem = new ToolStripMenuItem();
            heatedSeatsToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(btnUser);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(chkYourLocation);
            groupBox1.Controls.Add(chkRamp);
            groupBox1.Controls.Add(chkDoorLight);
            groupBox1.Controls.Add(chkVoiceAssistance);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 517);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Services";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ActiveCaptionText;
            btnUser.Font = new Font("Segoe UI", 10F);
            btnUser.ForeColor = SystemColors.ButtonHighlight;
            btnUser.Location = new Point(142, 438);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(147, 48);
            btnUser.TabIndex = 8;
            btnUser.Text = "User Data";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(315, 438);
            button1.Name = "button1";
            button1.Size = new Size(150, 48);
            button1.TabIndex = 6;
            button1.Text = "continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chkYourLocation
            // 
            chkYourLocation.AutoSize = true;
            chkYourLocation.Font = new Font("Segoe UI", 11F);
            chkYourLocation.Location = new Point(40, 339);
            chkYourLocation.Name = "chkYourLocation";
            chkYourLocation.Size = new Size(185, 29);
            chkYourLocation.TabIndex = 4;
            chkYourLocation.Text = "Use Your Location";
            chkYourLocation.UseVisualStyleBackColor = true;
            chkYourLocation.CheckedChanged += chkYourLocation_CheckedChanged;
            // 
            // chkRamp
            // 
            chkRamp.AutoSize = true;
            chkRamp.Font = new Font("Segoe UI", 11F);
            chkRamp.Location = new Point(40, 263);
            chkRamp.Name = "chkRamp";
            chkRamp.Size = new Size(82, 29);
            chkRamp.TabIndex = 3;
            chkRamp.Text = "Ramp";
            chkRamp.UseVisualStyleBackColor = true;
            chkRamp.CheckedChanged += chkRamp_CheckedChanged;
            // 
            // chkDoorLight
            // 
            chkDoorLight.AutoSize = true;
            chkDoorLight.Font = new Font("Segoe UI", 11F);
            chkDoorLight.Location = new Point(40, 192);
            chkDoorLight.Name = "chkDoorLight";
            chkDoorLight.Size = new Size(123, 29);
            chkDoorLight.TabIndex = 2;
            chkDoorLight.Text = "Door Light";
            chkDoorLight.UseVisualStyleBackColor = true;
            chkDoorLight.CheckedChanged += chkDoorLight_CheckedChanged;
            // 
            // chkVoiceAssistance
            // 
            chkVoiceAssistance.AutoSize = true;
            chkVoiceAssistance.Font = new Font("Segoe UI", 11F);
            chkVoiceAssistance.ForeColor = SystemColors.ButtonHighlight;
            chkVoiceAssistance.Location = new Point(40, 127);
            chkVoiceAssistance.Name = "chkVoiceAssistance";
            chkVoiceAssistance.Size = new Size(172, 29);
            chkVoiceAssistance.TabIndex = 1;
            chkVoiceAssistance.Text = "Voice Assistance";
            chkVoiceAssistance.UseVisualStyleBackColor = true;
            chkVoiceAssistance.CheckedChanged += chkVoiceAssistance_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tempratureToolStripMenuItem });
            menuStrip1.Location = new Point(3, 23);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(472, 31);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // tempratureToolStripMenuItem
            // 
            tempratureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCTempratureToolStripMenuItem, heatedSeatsToolStripMenuItem });
            tempratureToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            tempratureToolStripMenuItem.Name = "tempratureToolStripMenuItem";
            tempratureToolStripMenuItem.Size = new Size(111, 27);
            tempratureToolStripMenuItem.Text = "Temprature";
            // 
            // aCTempratureToolStripMenuItem
            // 
            aCTempratureToolStripMenuItem.Name = "aCTempratureToolStripMenuItem";
            aCTempratureToolStripMenuItem.Size = new Size(224, 28);
            aCTempratureToolStripMenuItem.Text = "AC Temprature";
            aCTempratureToolStripMenuItem.Click += aCTempratureToolStripMenuItem_Click;
            // 
            // heatedSeatsToolStripMenuItem
            // 
            heatedSeatsToolStripMenuItem.Name = "heatedSeatsToolStripMenuItem";
            heatedSeatsToolStripMenuItem.Size = new Size(224, 28);
            heatedSeatsToolStripMenuItem.Text = "heated seats";
            heatedSeatsToolStripMenuItem.Click += heatedSeatsToolStripMenuItem_Click;
            // 
            // Opts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 533);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "Opts";
            Text = "Opts";
            Load += Opts_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkYourLocation;
        private CheckBox chkRamp;
        private CheckBox chkDoorLight;
        private CheckBox chkVoiceAssistance;
        private Button button1;
        private Button btnUser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tempratureToolStripMenuItem;
        private ToolStripMenuItem aCTempratureToolStripMenuItem;
        private ToolStripMenuItem heatedSeatsToolStripMenuItem;
    }
}