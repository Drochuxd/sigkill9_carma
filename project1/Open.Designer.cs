namespace project1
{
    partial class Open
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnClick = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(118, 21);
            label1.Name = "label1";
            label1.Size = new Size(292, 38);
            label1.TabIndex = 0;
            label1.Text = "Get your Carma Now";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(158, 68);
            label2.Name = "label2";
            label2.Size = new Size(202, 38);
            label2.TabIndex = 1;
            label2.Text = "you deserve it";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(75, 344);
            label3.Name = "label3";
            label3.Size = new Size(377, 25);
            label3.TabIndex = 2;
            label3.Text = "An easier way to get where you want to go";
            label3.Click += label3_Click;
            // 
            // btnClick
            // 
            btnClick.BackColor = Color.Black;
            btnClick.Location = new Point(-1, 0);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(502, 534);
            btnClick.TabIndex = 3;
            btnClick.Text = "button1";
            btnClick.UseVisualStyleBackColor = false;
            btnClick.Click += btnClick_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(51, 393);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 115);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2025_10_26_201210;
            pictureBox2.Location = new Point(158, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 197);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Open
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(502, 533);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClick);
            Name = "Open";
            Text = "Open";
            Load += Open_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClick;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}