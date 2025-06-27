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
    public partial class CreateSalesReport : Form
    {
        public CreateSalesReport()
        {
            InitializeComponent();
        }

        private void CreateSalesReport_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                double inputProfit = Convert.ToDouble(txbProfit.Text);

                if (SalesReportBL.IsInitialProfitUnset())
                {
                    SalesReportBL.initialProfit = inputProfit;
                }
                else if (SalesReportBL.IsNewProfitUnset())
                {
                    SalesReportBL.newProfit = inputProfit;
                }
                else
                {
                    SalesReportBL.tempProfit = inputProfit;
                    SalesReportBL.UpdateProfit();
                }

                MessageBox.Show("Report created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
