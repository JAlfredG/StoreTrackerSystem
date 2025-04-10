using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSBusinessDataLogic
{
    public class SalesReportBL
    {
        public static double tempProfit = 0.0, initialProfit = 0.0, newProfit = 0.0, difference = 0.0, percentage = 0.0;
        

        public static bool CheckInitialProfit()
        {
             return initialProfit == 0.0;
        }
        public static bool CheckNewProfit()
        {
            return newProfit == 0.0;
        }

        public static void UpdateProfit()
        {
            initialProfit = newProfit;
            newProfit = tempProfit;
        }

        public static double CalculateProfitDifference()
        {
            if (newProfit != 0.0)
            {
                difference = newProfit - initialProfit;
            }
            
            return difference;
        }
        public static double CalculateProfitPercentage()
        {
            if (newProfit != 0.0)
            {
                percentage = ((newProfit - initialProfit)/initialProfit)*100;
            }
            return percentage;
        }
    }
}
