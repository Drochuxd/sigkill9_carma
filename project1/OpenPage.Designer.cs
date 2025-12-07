namespace project1
{
    partial class OpenPage
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
            login = new Button();
            register = new Button();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = Color.DarkGray;
            login.Location = new Point(208, 185);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 0;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // register
            // 
            register.BackColor = Color.DarkGray;
            register.Location = new Point(208, 301);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 1;
            register.Text = "REGISTER";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // OpenPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(502, 533);
            Controls.Add(register);
            Controls.Add(login);
            Name = "OpenPage";
            Text = "s";
            Load += OpenPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button login;
        private Button register;
    }
}