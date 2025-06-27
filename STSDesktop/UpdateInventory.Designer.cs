namespace STSDesktop
{
    partial class UpdateInventory
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
            txbItemName = new TextBox();
            txbItemQuantity = new TextBox();
            txbItemPrice = new TextBox();
            lblItemName = new Label();
            lblItemQuantity = new Label();
            lblItemPrice = new Label();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            btnUpdateQuantity = new Button();
            btnUpdatePrice = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(248, 38);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Update Inventory";
            // 
            // txbItemName
            // 
            txbItemName.BorderStyle = BorderStyle.FixedSingle;
            txbItemName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbItemName.Location = new Point(30, 119);
            txbItemName.Name = "txbItemName";
            txbItemName.Size = new Size(350, 34);
            txbItemName.TabIndex = 4;
            // 
            // txbItemQuantity
            // 
            txbItemQuantity.BorderStyle = BorderStyle.FixedSingle;
            txbItemQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbItemQuantity.Location = new Point(30, 219);
            txbItemQuantity.Name = "txbItemQuantity";
            txbItemQuantity.Size = new Size(350, 34);
            txbItemQuantity.TabIndex = 5;
            // 
            // txbItemPrice
            // 
            txbItemPrice.BorderStyle = BorderStyle.FixedSingle;
            txbItemPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbItemPrice.Location = new Point(30, 319);
            txbItemPrice.Name = "txbItemPrice";
            txbItemPrice.Size = new Size(350, 34);
            txbItemPrice.TabIndex = 6;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemName.Location = new Point(30, 88);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(108, 28);
            lblItemName.TabIndex = 7;
            lblItemName.Text = "Item Name";
            // 
            // lblItemQuantity
            // 
            lblItemQuantity.AutoSize = true;
            lblItemQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemQuantity.Location = new Point(30, 188);
            lblItemQuantity.Name = "lblItemQuantity";
            lblItemQuantity.Size = new Size(132, 28);
            lblItemQuantity.TabIndex = 8;
            lblItemQuantity.Text = "Item Quantity";
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemPrice.Location = new Point(30, 288);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(98, 28);
            lblItemPrice.TabIndex = 9;
            lblItemPrice.Text = "Item Price";
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(430, 93);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(195, 53);
            btnAddItem.TabIndex = 10;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveItem.Location = new Point(430, 152);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(195, 53);
            btnRemoveItem.TabIndex = 11;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateQuantity.Location = new Point(430, 214);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new Size(195, 53);
            btnUpdateQuantity.TabIndex = 12;
            btnUpdateQuantity.Text = "Update Quantity";
            btnUpdateQuantity.UseVisualStyleBackColor = true;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePrice.Location = new Point(430, 273);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(195, 53);
            btnUpdatePrice.TabIndex = 13;
            btnUpdatePrice.Text = "Update Price";
            btnUpdatePrice.UseVisualStyleBackColor = true;
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(430, 332);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(195, 53);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 408);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdatePrice);
            Controls.Add(btnUpdateQuantity);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddItem);
            Controls.Add(lblItemPrice);
            Controls.Add(lblItemQuantity);
            Controls.Add(lblItemName);
            Controls.Add(txbItemPrice);
            Controls.Add(txbItemQuantity);
            Controls.Add(txbItemName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store Tracker System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txbItemName;
        private TextBox txbItemQuantity;
        private TextBox txbItemPrice;
        private Label lblItemName;
        private Label lblItemQuantity;
        private Label lblItemPrice;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private Button btnUpdateQuantity;
        private Button btnUpdatePrice;
        private Button btnCancel;
    }
}