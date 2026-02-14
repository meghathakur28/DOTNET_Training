using System;
using System.Collections.Generic;
using System.Text;

namespace HealthSyncAdvancedBilling
{
    public class Visiting : Consultant
    {
        int visit;
        double rate;
        public Visiting(int visit, double rate)
        {
            this.visit = visit;
            this.rate = rate;
        }
        public override double CalculateGrossPayout()
        {
            double gross = visit * rate;
            return gross;
        }
    }
}
