namespace STSDesktop
{
    partial class Login
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
            btnLogin = new Button();
            txbUsername = new TextBox();
            txbPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(239, 254);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(174, 43);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txbUsername
            // 
            txbUsername.BorderStyle = BorderStyle.FixedSingle;
            txbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUsername.Location = new Point(198, 65);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(363, 39);
            txbUsername.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.BorderStyle = BorderStyle.FixedSingle;
            txbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPassword.Location = new Point(198, 157);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(363, 39);
            txbPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(33, 65);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(135, 32);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(33, 157);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(129, 32);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 349);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txbPassword);
            Controls.Add(txbUsername);
            Controls.Add(btnLogin);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store Tracker System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txbUsername;
        private TextBox txbPassword;
        private Label lblUsername;
        private Label lblPassword;
    }
}
