namespace project1
{
    partial class Waiting
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
            locationLabel = new Label();
            destinationLabel = new Label();
            distanceLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnReturn = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // locationLabel
            // 
            locationLabel.BackColor = Color.Transparent;
            locationLabel.FlatStyle = FlatStyle.Flat;
            locationLabel.ForeColor = SystemColors.ButtonHighlight;
            locationLabel.ImageAlign = ContentAlignment.TopLeft;
            locationLabel.Location = new Point(171, 18);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(162, 20);
            locationLabel.TabIndex = 1;
            locationLabel.Text = "label1";
            locationLabel.Click += locationLabel_Click;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.BackColor = Color.Transparent;
            destinationLabel.FlatStyle = FlatStyle.Flat;
            destinationLabel.ForeColor = SystemColors.ButtonHighlight;
            destinationLabel.Location = new Point(306, 53);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(50, 20);
            destinationLabel.TabIndex = 2;
            destinationLabel.Text = "label2";
            destinationLabel.Click += destinationLabel_Click;
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            distanceLabel.ForeColor = SystemColors.ButtonHighlight;
            distanceLabel.Location = new Point(190, 199);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new Size(70, 28);
            distanceLabel.TabIndex = 3;
            distanceLabel.Text = "label2";
            distanceLabel.Click += distanceLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Image = Properties.Resources.city_map_navigation_interface_gps_navigator_screen_8071_8265;
            pictureBox1.Location = new Point(-65, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 435);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(11, 53);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 5;
            label1.Text = "please wait pationtly and we will get you to ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(11, 18);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 6;
            label2.Text = "you ride is on its way to";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(385, 479);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(destinationLabel);
            panel1.Controls.Add(locationLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 95);
            panel1.TabIndex = 8;
            // 
            // Waiting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(502, 533);
            Controls.Add(panel1);
            Controls.Add(distanceLabel);
            Controls.Add(btnReturn);
            Controls.Add(pictureBox1);
            Name = "Waiting";
            Text = "Waiting";
            Load += Waiting_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label locationLabel;
        private Label destinationLabel;
        private Label distanceLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnReturn;
        private Panel panel1;
    }
}