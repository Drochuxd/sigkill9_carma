namespace project1
{
    partial class UserData
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
            fName = new Label();
            lName = new Label();
            label5 = new Label();
            emailAddress = new Label();
            btnReturn = new Button();
            btnLogout = new Button();
            btnService = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(143, 125);
            label1.Name = "label1";
            label1.Size = new Size(214, 35);
            label1.TabIndex = 0;
            label1.Text = "Users Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(51, 221);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 1;
            label2.Text = "Your Name is";
            // 
            // fName
            // 
            fName.AutoSize = true;
            fName.Font = new Font("Segoe UI", 12F);
            fName.Location = new Point(183, 221);
            fName.Name = "fName";
            fName.Size = new Size(65, 28);
            fName.TabIndex = 2;
            fName.Text = "label3";
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Font = new Font("Segoe UI", 12F);
            lName.ForeColor = SystemColors.ButtonHighlight;
            lName.Location = new Point(254, 221);
            lName.Name = "lName";
            lName.Size = new Size(65, 28);
            lName.TabIndex = 3;
            lName.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(51, 308);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 4;
            label5.Text = "Your Email is";
            // 
            // emailAddress
            // 
            emailAddress.AutoSize = true;
            emailAddress.Font = new Font("Segoe UI", 12F);
            emailAddress.Location = new Point(178, 308);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(65, 28);
            emailAddress.TabIndex = 9;
            emailAddress.Text = "label6";
            // 
            // btnReturn
            // 
            btnReturn.AccessibleRole = AccessibleRole.None;
            btnReturn.BackColor = Color.DarkGray;
            btnReturn.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.Black;
            btnReturn.Location = new Point(332, 457);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(158, 53);
            btnReturn.TabIndex = 10;
            btnReturn.Text = "RETURN";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.AppWorkspace;
            btnLogout.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(24, 35);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(133, 44);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnService
            // 
            btnService.BackColor = SystemColors.AppWorkspace;
            btnService.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnService.ForeColor = SystemColors.ActiveCaptionText;
            btnService.Location = new Point(143, 457);
            btnService.Name = "btnService";
            btnService.Size = new Size(158, 53);
            btnService.TabIndex = 13;
            btnService.Text = "Services";
            btnService.UseVisualStyleBackColor = false;
            btnService.Click += btnService_Click;
            // 
            // UserData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(502, 533);
            Controls.Add(btnService);
            Controls.Add(btnLogout);
            Controls.Add(btnReturn);
            Controls.Add(emailAddress);
            Controls.Add(label5);
            Controls.Add(lName);
            Controls.Add(fName);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "UserData";
            Text = "Form3";
            Load += UserData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label fName;
        private Label lName;
        private Label label5;
        private Label emailAddress;
        private Button btnReturn;
        private Button btnLogout;
        private Button btnService;
    }
}