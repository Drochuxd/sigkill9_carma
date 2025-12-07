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
            lightsBtn = new Button();
            numericUpDown1 = new NumericUpDown();
            panelHeatedSeats = new Panel();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelHeatedSeats.SuspendLayout();
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
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(149, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Heated seats";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedValueChanged += comboBox1_SelectedIndexChanged;
            // 
            // lightsBtn
            // 
            lightsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            lightsBtn.Location = new Point(27, 146);
            lightsBtn.Name = "lightsBtn";
            lightsBtn.RightToLeft = RightToLeft.No;
            lightsBtn.Size = new Size(151, 29);
            lightsBtn.TabIndex = 2;
            lightsBtn.Text = "lights";
            lightsBtn.TextAlign = ContentAlignment.MiddleLeft;
            lightsBtn.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(149, 48);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
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
            panelHeatedSeats.Size = new Size(353, 92);
            panelHeatedSeats.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 11);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 5;
            label1.Text = "Heated seats";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(20, 48);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "On/Off";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Traveling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 533);
            Controls.Add(panelHeatedSeats);
            Controls.Add(lightsBtn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Traveling";
            Text = "Traveling";
            Load += Traveling_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelHeatedSeats.ResumeLayout(false);
            panelHeatedSeats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ComboBox comboBox1;
        private Button lightsBtn;
        private NumericUpDown numericUpDown1;
        private Panel panelHeatedSeats;
        private Label label1;
        private Button button1;
    }
}