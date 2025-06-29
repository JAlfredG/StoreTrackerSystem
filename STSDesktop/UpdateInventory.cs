﻿using STSBusinessDataLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSDesktop
{
    public partial class UpdateInventory : Form
    {
        public UpdateInventory()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txbItemName.Text.Trim();
                int itemQuantity = int.Parse(txbItemQuantity.Text);
                double itemPrice = double.Parse(txbItemPrice.Text);
                
                if (!InventoryBL.CheckItemInInventory(itemName))
                {
                    if (InventoryBL.CheckItemQuantity(itemQuantity))
                    {
                        InventoryBL.AddItem(itemName, itemQuantity, (int)itemPrice);
                        MessageBox.Show($"'{itemName}' added to the inventory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbItemName.Clear();
                        txbItemQuantity.Clear();
                        txbItemPrice.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid item quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Item already exist in the inventory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                 
            } catch
            {
                MessageBox.Show("Invalid Inputs. All fields must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            string itemName = txbItemName.Text.Trim();

            if (InventoryBL.CheckInventory())
            {
                if (txbItemQuantity.Text == "" && txbItemPrice.Text == "")
                {
                    if (InventoryBL.CheckItemInInventory(itemName))
                    {
                        InventoryBL.RemoveItem(itemName);
                        MessageBox.Show($"'{itemName}' removed from inventory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbItemName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Only item name must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Inventory is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txbItemName.Text.Trim();
                int itemQuantity = int.Parse(txbItemQuantity.Text);

                if(txbItemPrice.Text == "")
                {
                    if (InventoryBL.CheckItemInInventory(itemName))
                    {
                        if (InventoryBL.CheckItemQuantity(itemQuantity))
                        {
                            InventoryBL.UpdateQuantity(itemName, itemQuantity);
                            MessageBox.Show($"'{itemName}' quantity updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txbItemName.Clear();
                            txbItemQuantity.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid item quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item does not exist in the inventory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Only item name and item quantity fields must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("Invalid Inputs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txbItemName.Text.Trim();
                double itemPrice = double.Parse(txbItemPrice.Text);

                if (txbItemQuantity.Text == "")
                {
                    if (InventoryBL.CheckItemInInventory(itemName))
                    {
                        InventoryBL.UpdatePrice(itemName, itemPrice);
                        MessageBox.Show($"'{itemName}' price updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbItemName.Clear();
                        txbItemPrice.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Item does not exist in the inventory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Only item name and item price fields must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("Invalid Inputs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
