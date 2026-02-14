using System;
using System.Collections.Generic;
using System.Text;

namespace HealthSyncAdvancedBilling
{
    public class MonthlyStipend: Consultant
    {
        double stipend;
        public MonthlyStipend(double stipend)
        {
            this.stipend = stipend;
        }
        public override double CalculateGrossPayout()
        {
            double gross = stipend + 2000 + 1000;
            return gross;
        }
    }
}
