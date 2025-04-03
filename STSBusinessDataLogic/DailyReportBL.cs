using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSBusinessDataLogic
{
    public class DailyReportBL
    {
        public static string dailyReport = null;

        public static bool CheckDailyReport()
        {
            if (dailyReport != null)
            {
                return true;
            }
            return false;
        }

        public static string createDailyReport(string report)
        {
            dailyReport = report;
            return dailyReport;
        }
    }
}
