namespace project1
{
    partial class RequestCar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestCar));
            Request = new Button();
            enterDestanation = new TextBox();
            enterLocation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnUser = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Request
            // 
            Request.BackColor = Color.Black;
            Request.ForeColor = SystemColors.ButtonFace;
            Request.Location = new Point(64, 463);
            Request.Name = "Request";
            Request.Size = new Size(332, 48);
            Request.TabIndex = 3;
            Request.Text = "REQUEST CARMA";
            Request.UseVisualStyleBackColor = false;
            Request.Click += Request_Click;
            // 
            // enterDestanation
            // 
            enterDestanation.BackColor = SystemColors.InactiveCaptionText;
            enterDestanation.BorderStyle = BorderStyle.None;
            enterDestanation.ForeColor = Color.FromArgb(224, 224, 224);
            enterDestanation.Location = new Point(157, 367);
            enterDestanation.Name = "enterDestanation";
            enterDestanation.Size = new Size(239, 20);
            enterDestanation.TabIndex = 4;
            enterDestanation.Text = "Enter Your Destanation";
            enterDestanation.TextChanged += enterDestanation_TextChanged;
            // 
            // enterLocation
            // 
            enterLocation.BackColor = SystemColors.InactiveCaptionText;
            enterLocation.BorderStyle = BorderStyle.FixedSingle;
            enterLocation.ForeColor = Color.FromArgb(224, 224, 224);
            enterLocation.Location = new Point(157, 326);
            enterLocation.Name = "enterLocation";
            enterLocation.Size = new Size(239, 27);
            enterLocation.TabIndex = 5;
            enterLocation.Text = "Enter Your Location";
            enterLocation.TextChanged += enterLocation_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(66, 326);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 6;
            label1.Text = "Pickup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(66, 367);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Drop-off";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 200);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(140, 240);
            label3.Name = "label3";
            label3.Size = new Size(234, 20);
            label3.TabIndex = 9;
            label3.Text = "AUTONOMOUS RIDE NETWORK";
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ActiveCaptionText;
            btnUser.ForeColor = SystemColors.ButtonFace;
            btnUser.Location = new Point(12, 37);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(94, 29);
            btnUser.TabIndex = 10;
            btnUser.Text = "USER";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 408);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(157, 408);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 20);
            textBox1.TabIndex = 12;
            textBox1.Text = "Enter Password";
            // 
            // RequestCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(502, 533);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(btnUser);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(enterLocation);
            Controls.Add(enterDestanation);
            Controls.Add(Request);
            ForeColor = SystemColors.Control;
            Name = "RequestCar";
            Text = "Form1";
            Load += RequestCar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Request;
        private TextBox enterDestanation;
        private TextBox enterLocation;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnUser;
        private Label label4;
        private TextBox textBox1;
    }
}
