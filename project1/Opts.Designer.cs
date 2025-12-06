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
            checkBox1 = new CheckBox();
            chkYourLocation = new CheckBox();
            chkRamp = new CheckBox();
            chkDoorLight = new CheckBox();
            chkVoiceAssistance = new CheckBox();
            menuStrip1 = new MenuStrip();
            lightsToolStripMenuItem = new ToolStripMenuItem();
            doorToolStripMenuItem = new ToolStripMenuItem();
            interiorToolStripMenuItem = new ToolStripMenuItem();
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
            groupBox1.Controls.Add(checkBox1);
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
            btnUser.ForeColor = SystemColors.ButtonHighlight;
            btnUser.Location = new Point(160, 445);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(143, 41);
            btnUser.TabIndex = 8;
            btnUser.Text = "User Data";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(322, 445);
            button1.Name = "button1";
            button1.Size = new Size(143, 41);
            button1.TabIndex = 6;
            button1.Text = "continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(40, 281);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(139, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Voice Assistance";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkYourLocation
            // 
            chkYourLocation.AutoSize = true;
            chkYourLocation.Location = new Point(40, 231);
            chkYourLocation.Name = "chkYourLocation";
            chkYourLocation.Size = new Size(147, 24);
            chkYourLocation.TabIndex = 4;
            chkYourLocation.Text = "use Your Location";
            chkYourLocation.UseVisualStyleBackColor = true;
            chkYourLocation.CheckedChanged += chkYourLocation_CheckedChanged;
            // 
            // chkRamp
            // 
            chkRamp.AutoSize = true;
            chkRamp.Location = new Point(40, 175);
            chkRamp.Name = "chkRamp";
            chkRamp.Size = new Size(70, 24);
            chkRamp.TabIndex = 3;
            chkRamp.Text = "Ramp";
            chkRamp.UseVisualStyleBackColor = true;
            chkRamp.CheckedChanged += chkRamp_CheckedChanged;
            // 
            // chkDoorLight
            // 
            chkDoorLight.AutoSize = true;
            chkDoorLight.Location = new Point(40, 125);
            chkDoorLight.Name = "chkDoorLight";
            chkDoorLight.Size = new Size(102, 24);
            chkDoorLight.TabIndex = 2;
            chkDoorLight.Text = "Door Light";
            chkDoorLight.UseVisualStyleBackColor = true;
            chkDoorLight.CheckedChanged += chkDoorLight_CheckedChanged;
            // 
            // chkVoiceAssistance
            // 
            chkVoiceAssistance.AutoSize = true;
            chkVoiceAssistance.ForeColor = SystemColors.ButtonHighlight;
            chkVoiceAssistance.Location = new Point(40, 76);
            chkVoiceAssistance.Name = "chkVoiceAssistance";
            chkVoiceAssistance.Size = new Size(139, 24);
            chkVoiceAssistance.TabIndex = 1;
            chkVoiceAssistance.Text = "Voice Assistance";
            chkVoiceAssistance.UseVisualStyleBackColor = true;
            chkVoiceAssistance.CheckedChanged += chkVoiceAssistance_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { lightsToolStripMenuItem, tempratureToolStripMenuItem });
            menuStrip1.Location = new Point(3, 23);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(472, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // lightsToolStripMenuItem
            // 
            lightsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doorToolStripMenuItem, interiorToolStripMenuItem });
            lightsToolStripMenuItem.Name = "lightsToolStripMenuItem";
            lightsToolStripMenuItem.Size = new Size(59, 24);
            lightsToolStripMenuItem.Text = "lights";
            lightsToolStripMenuItem.Click += lightsToolStripMenuItem_Click;
            // 
            // doorToolStripMenuItem
            // 
            doorToolStripMenuItem.Name = "doorToolStripMenuItem";
            doorToolStripMenuItem.Size = new Size(224, 26);
            doorToolStripMenuItem.Text = "Door";
            // 
            // interiorToolStripMenuItem
            // 
            interiorToolStripMenuItem.Name = "interiorToolStripMenuItem";
            interiorToolStripMenuItem.Size = new Size(224, 26);
            interiorToolStripMenuItem.Text = "Interior";
            // 
            // tempratureToolStripMenuItem
            // 
            tempratureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCTempratureToolStripMenuItem, heatedSeatsToolStripMenuItem });
            tempratureToolStripMenuItem.Name = "tempratureToolStripMenuItem";
            tempratureToolStripMenuItem.Size = new Size(97, 24);
            tempratureToolStripMenuItem.Text = "temprature";
            // 
            // aCTempratureToolStripMenuItem
            // 
            aCTempratureToolStripMenuItem.Name = "aCTempratureToolStripMenuItem";
            aCTempratureToolStripMenuItem.Size = new Size(224, 26);
            aCTempratureToolStripMenuItem.Text = "AC Temprature";
            // 
            // heatedSeatsToolStripMenuItem
            // 
            heatedSeatsToolStripMenuItem.Name = "heatedSeatsToolStripMenuItem";
            heatedSeatsToolStripMenuItem.Size = new Size(224, 26);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private CheckBox chkYourLocation;
        private CheckBox chkRamp;
        private CheckBox chkDoorLight;
        private CheckBox chkVoiceAssistance;
        private Button button1;
        private Button btnUser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lightsToolStripMenuItem;
        private ToolStripMenuItem doorToolStripMenuItem;
        private ToolStripMenuItem interiorToolStripMenuItem;
        private ToolStripMenuItem tempratureToolStripMenuItem;
        private ToolStripMenuItem aCTempratureToolStripMenuItem;
        private ToolStripMenuItem heatedSeatsToolStripMenuItem;
    }
}