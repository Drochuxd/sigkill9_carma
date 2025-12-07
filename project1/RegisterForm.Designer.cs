namespace project1
{
    partial class RegisterForm
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
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmailAddress = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(396, 492);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(61, 66);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(61, 113);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Last name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(61, 161);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.DarkGray;
            txtFirstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtFirstName.Location = new Point(154, 66);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 31);
            txtFirstName.TabIndex = 6;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.DarkGray;
            txtLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtLastName.Location = new Point(154, 113);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 31);
            txtLastName.TabIndex = 7;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BackColor = Color.DarkGray;
            txtEmailAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtEmailAddress.Location = new Point(154, 161);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(280, 31);
            txtEmailAddress.TabIndex = 8;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(502, 533);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmailAddress;
    }
}