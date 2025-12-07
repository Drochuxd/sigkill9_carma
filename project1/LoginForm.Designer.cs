namespace project1
{
    partial class LoginForm
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
            label3 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            LoginBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(59, 117);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(59, 179);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.DarkGray;
            txtUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtUser.Location = new Point(169, 112);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(283, 30);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.DarkGray;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtPassword.Location = new Point(169, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 30);
            txtPassword.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DarkGray;
            LoginBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ActiveCaptionText;
            LoginBtn.Location = new Point(169, 255);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 61);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkGray;
            cancelBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            cancelBtn.Location = new Point(282, 255);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 61);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(502, 533);
            Controls.Add(cancelBtn);
            Controls.Add(LoginBtn);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button LoginBtn;
        private Button cancelBtn;
    }
}