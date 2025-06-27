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
    public partial class CreateDailyReport : Form
    {
        public CreateDailyReport()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dailyReport = rtxbDailyReport.Text;

            DailyReportBL.CreateDailyReport(dailyReport);
            MessageBox.Show("Report created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
