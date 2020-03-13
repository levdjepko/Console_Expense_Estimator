using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleExpenseTracking_withClasses
{
    public static class WealthEstimator
    {
        public static double GetEstimate (double value)
        {
            //for monthly expenses, multiply those by 173, or make the real compuatation
            //7% a year compounding interest
            double total = value;
            for (int i = 1; i < 120; i++)//get monthly expense + montly lost interest
            {
                total = total + value;
                total = total + total * (7.0 / 100.0 / 12.0);//get monthly interest
            }
            return total;
        }
    }
}
