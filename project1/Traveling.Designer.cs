namespace project1
{
    partial class Traveling
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
            menuStrip1 = new MenuStrip();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            panelHeatedSeats = new Panel();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelHeatedSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(502, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.AppWorkspace;
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.ForeColor = SystemColors.InactiveCaptionText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(181, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Heated seats";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedValueChanged += comboBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.AppWorkspace;
            numericUpDown1.Font = new Font("Segoe UI", 11F);
            numericUpDown1.ForeColor = SystemColors.InfoText;
            numericUpDown1.Location = new Point(182, 86);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 32);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // panelHeatedSeats
            // 
            panelHeatedSeats.AutoScroll = true;
            panelHeatedSeats.BorderStyle = BorderStyle.FixedSingle;
            panelHeatedSeats.Controls.Add(button1);
            panelHeatedSeats.Controls.Add(numericUpDown1);
            panelHeatedSeats.Controls.Add(label1);
            panelHeatedSeats.Controls.Add(comboBox1);
            panelHeatedSeats.Location = new Point(27, 27);
            panelHeatedSeats.Name = "panelHeatedSeats";
            panelHeatedSeats.Size = new Size(372, 145);
            panelHeatedSeats.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(21, 86);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 5;
            button1.Text = "On/Off";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 5;
            label1.Text = "Heated seats";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(210, 205);
            button2.Name = "button2";
            button2.Size = new Size(170, 57);
            button2.TabIndex = 5;
            button2.Text = "On/Off";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(48, 222);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 6;
            label2.Text = "Lights";
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = SystemColors.AppWorkspace;
            numericUpDown2.Font = new Font("Segoe UI", 12F);
            numericUpDown2.ForeColor = SystemColors.InactiveCaptionText;
            numericUpDown2.Location = new Point(210, 300);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(170, 34);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(37, 304);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 8;
            label3.Text = "Temperature";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(37, 385);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 9;
            label4.Text = " Windows";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(210, 372);
            button3.Name = "button3";
            button3.Size = new Size(170, 55);
            button3.TabIndex = 10;
            button3.Text = "Up/Down";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Traveling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(502, 533);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(panelHeatedSeats);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Traveling";
            Text = "Traveling";
            Load += Traveling_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelHeatedSeats.ResumeLayout(false);
            panelHeatedSeats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Panel panelHeatedSeats;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label4;
        private Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}