using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LogisticsProShipmentSystem
{
    public class ShipmentDetails:Shipment
    {
        double ratePerKg = 0;
        public void Rate ()
        {
            if(TransportMode.Equals("Sea"))
            {
                ratePerKg = 15.00;
            }
            else if(TransportMode.Equals("Air"))
            {
                ratePerKg = 50.00;
            }
            else if(TransportMode.Equals("Land"))
            {
                ratePerKg = 25.00;
            }
            else
            {
                ratePerKg = 0;
            }
        }
        
        public bool ValidateShipmentCode(string code)
        {
            if(code.Length == 7)
            {
                bool val = Regex.IsMatch(code, @"[GC#]{3}[0-9]{4}");
                if(val)
                {
                    return true;
                }
            }
            return false;
        }

        public double CalculateTotalCost()
        {
            Rate();
            double totalCost = (Weight * ratePerKg) + Math.Sqrt(StorageDays);
            return totalCost;
        }
    }
}
