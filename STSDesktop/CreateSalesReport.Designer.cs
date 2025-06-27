namespace STSDesktop
{
    partial class CreateSalesReport
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
            lblTitle = new Label();
            txbProfit = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            lblProfit = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 38);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Sales Report";
            // 
            // txbProfit
            // 
            txbProfit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbProfit.Location = new Point(105, 92);
            txbProfit.Name = "txbProfit";
            txbProfit.Size = new Size(292, 37);
            txbProfit.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmit.Location = new Point(105, 158);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(139, 47);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(258, 158);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 47);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfit.Location = new Point(12, 92);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(74, 30);
            lblProfit.TabIndex = 6;
            lblProfit.Text = "Profit:";
            // 
            // CreateSalesReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 224);
            Controls.Add(lblProfit);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txbProfit);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateSalesReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store Tracker System";
            Load += CreateSalesReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txbProfit;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblProfit;
    }
}