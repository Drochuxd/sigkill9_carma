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
            btnRegister.BackColor = SystemColors.AppWorkspace;
            btnRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRegister.Location = new Point(302, 463);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(188, 58);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 96);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 3;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 194);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 4;
            label2.Text = "Last name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(52, 294);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.DarkGray;
            txtFirstName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txtFirstName.Location = new Point(163, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 41);
            txtFirstName.TabIndex = 6;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.DarkGray;
            txtLastName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txtLastName.Location = new Point(163, 193);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 41);
            txtLastName.TabIndex = 7;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BackColor = Color.DarkGray;
            txtEmailAddress.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txtEmailAddress.Location = new Point(163, 287);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(280, 41);
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