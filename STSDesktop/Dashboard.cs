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
        private void button2_Click(object sender, EventArgs e)
        {
            if (DailyReportBL.CheckDailyReport())
            {
                rtbMainInterface.Text = $"Daily Report:\n\n {DailyReportBL.dailyReport}";

            }
            else
            {
                rtbMainInterface.Text = "No current Report.";
            }
        }

        private void btnShowSalesReport_Click(object sender, EventArgs e)
        {
            if (!SalesReportBL.IsInitialProfitUnset())
            {
                SalesReportBL.CalculateProfitDifference();
                SalesReportBL.CalculateProfitPercentage();

                rtbMainInterface.Text = "Last Daily Report:\n\n";
                rtbMainInterface.AppendText($"Initial Profit     : {SalesReportBL.initialProfit}\n");
                rtbMainInterface.AppendText($"Today's Profit     : {SalesReportBL.newProfit}\n");
                rtbMainInterface.AppendText($"Profit Difference  : {SalesReportBL.difference}\n");
                rtbMainInterface.AppendText($"Profit Percentage  : {SalesReportBL.percentage:F2}%\n");
            }
            else
            {
                rtbMainInterface.Text = "No current Report.";
            }
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateDailyReport_Click(object sender, EventArgs e)
        {
            CreateDailyReport dailyReport = new CreateDailyReport();

            dailyReport.FormClosed += (s, args) => this.Show();

            dailyReport.Show();
            this.Hide();
        }

        private void btnCreateSalesReport_Click(object sender, EventArgs e)
        {

        }
    }
}
