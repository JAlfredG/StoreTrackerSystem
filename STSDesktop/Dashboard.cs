using STSBusinessDataLogic;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowInventory_Click(object sender, EventArgs e)
        {
            if (InventoryBL.CheckInventory())
            {
                rtbMainInterface.Text = "Item Name             :    Quantity        :       Price\n\n";

                foreach (var item in InventoryBL.GetInventory())
                {
                    rtbMainInterface.AppendText(
                        item.ItemName.PadRight(15) + "\t\t:\t" +
                        item.ItemQuantity.ToString().PadRight(9) + "   :\t" +
                        item.ItemPrice + " pesos\n"
                    );
                }

            }
            else
            {
                rtbMainInterface.Text = "Inventory is Empty.";
            }

        }
    }
}
