namespace STSDesktop
{
    partial class Dashboard
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
            rtbMainInterface = new RichTextBox();
            lblDashboard = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // rtbMainInterface
            // 
            rtbMainInterface.BackColor = SystemColors.MenuText;
            rtbMainInterface.BorderStyle = BorderStyle.FixedSingle;
            rtbMainInterface.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbMainInterface.ForeColor = SystemColors.Window;
            rtbMainInterface.Location = new Point(12, 86);
            rtbMainInterface.Name = "rtbMainInterface";
            rtbMainInterface.ReadOnly = true;
            rtbMainInterface.Size = new Size(641, 519);
            rtbMainInterface.TabIndex = 0;
            rtbMainInterface.Text = "Welcome to Store Tracker Interface";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(12, 22);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(159, 38);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Dashboard";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(675, 86);
            button1.Name = "button1";
            button1.Size = new Size(237, 69);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(675, 161);
            button2.Name = "button2";
            button2.Size = new Size(237, 69);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(675, 236);
            button3.Name = "button3";
            button3.Size = new Size(237, 69);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(675, 461);
            button4.Name = "button4";
            button4.Size = new Size(237, 69);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(675, 386);
            button5.Name = "button5";
            button5.Size = new Size(237, 69);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(675, 311);
            button6.Name = "button6";
            button6.Size = new Size(237, 69);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Brown;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(675, 536);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(237, 69);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 633);
            Controls.Add(btnLogout);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblDashboard);
            Controls.Add(rtbMainInterface);
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store Tracker Sytem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbMainInterface;
        private Label lblDashboard;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnLogout;
    }
}