namespace STSDesktop
{
    partial class CreateDailyReport
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
            rtxbDailyReport = new RichTextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 38);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Daily Report";
            // 
            // rtxbDailyReport
            // 
            rtxbDailyReport.BorderStyle = BorderStyle.FixedSingle;
            rtxbDailyReport.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtxbDailyReport.Location = new Point(12, 76);
            rtxbDailyReport.Name = "rtxbDailyReport";
            rtxbDailyReport.Size = new Size(609, 283);
            rtxbDailyReport.TabIndex = 3;
            rtxbDailyReport.Text = "";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmit.Location = new Point(12, 365);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(297, 76);
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
            btnCancel.Location = new Point(324, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(297, 76);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button2_Click;
            // 
            // CreateDailyReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 453);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(rtxbDailyReport);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateDailyReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store Tracker System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RichTextBox rtxbDailyReport;
        private Button btnSubmit;
        private Button btnCancel;
    }
}