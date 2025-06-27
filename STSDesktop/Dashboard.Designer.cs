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
            btnShowInventory = new Button();
            btnShowDailyReport = new Button();
            btnShowSalesReport = new Button();
            btnCreateSalesReport = new Button();
            btnCreateDailyReport = new Button();
            btnUpdateInventory = new Button();
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
            // btnShowInventory
            // 
            btnShowInventory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowInventory.Location = new Point(675, 86);
            btnShowInventory.Name = "btnShowInventory";
            btnShowInventory.Size = new Size(237, 69);
            btnShowInventory.TabIndex = 2;
            btnShowInventory.Text = "Show Inventory";
            btnShowInventory.UseVisualStyleBackColor = true;
            btnShowInventory.Click += btnShowInventory_Click;
            // 
            // btnShowDailyReport
            // 
            btnShowDailyReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowDailyReport.Location = new Point(675, 161);
            btnShowDailyReport.Name = "btnShowDailyReport";
            btnShowDailyReport.Size = new Size(237, 69);
            btnShowDailyReport.TabIndex = 3;
            btnShowDailyReport.Text = "Show Daily Report";
            btnShowDailyReport.UseVisualStyleBackColor = true;
            btnShowDailyReport.Click += button2_Click;
            // 
            // btnShowSalesReport
            // 
            btnShowSalesReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowSalesReport.Location = new Point(675, 236);
            btnShowSalesReport.Name = "btnShowSalesReport";
            btnShowSalesReport.Size = new Size(237, 69);
            btnShowSalesReport.TabIndex = 4;
            btnShowSalesReport.Text = "Show Sales Report";
            btnShowSalesReport.UseVisualStyleBackColor = true;
            btnShowSalesReport.Click += btnShowSalesReport_Click;
            // 
            // btnCreateSalesReport
            // 
            btnCreateSalesReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateSalesReport.Location = new Point(675, 461);
            btnCreateSalesReport.Name = "btnCreateSalesReport";
            btnCreateSalesReport.Size = new Size(237, 69);
            btnCreateSalesReport.TabIndex = 7;
            btnCreateSalesReport.Text = "Create Sales Report";
            btnCreateSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnCreateDailyReport
            // 
            btnCreateDailyReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateDailyReport.Location = new Point(675, 386);
            btnCreateDailyReport.Name = "btnCreateDailyReport";
            btnCreateDailyReport.Size = new Size(237, 69);
            btnCreateDailyReport.TabIndex = 6;
            btnCreateDailyReport.Text = "Create Daily Report";
            btnCreateDailyReport.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInventory
            // 
            btnUpdateInventory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateInventory.Location = new Point(675, 311);
            btnUpdateInventory.Name = "btnUpdateInventory";
            btnUpdateInventory.Size = new Size(237, 69);
            btnUpdateInventory.TabIndex = 5;
            btnUpdateInventory.Text = "Update Inventory";
            btnUpdateInventory.UseVisualStyleBackColor = true;
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
            Controls.Add(btnCreateSalesReport);
            Controls.Add(btnCreateDailyReport);
            Controls.Add(btnUpdateInventory);
            Controls.Add(btnShowSalesReport);
            Controls.Add(btnShowDailyReport);
            Controls.Add(btnShowInventory);
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
        private Button btnShowInventory;
        private Button btnShowDailyReport;
        private Button btnShowSalesReport;
        private Button btnCreateSalesReport;
        private Button btnCreateDailyReport;
        private Button btnUpdateInventory;
        private Button btnLogout;
    }
}