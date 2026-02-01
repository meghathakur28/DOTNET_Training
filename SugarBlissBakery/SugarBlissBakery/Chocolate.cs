using System;
using System.Collections.Generic;
using System.Text;

namespace SugarBlissBakery
{
    public class Chocolate
    {
        public string Flavour {  get; set; }
        public int Quantity { get; set; }
        public int PricePerUnit {  get; set; }

        public double TotalPrice { get; set; }
        public double DiscountedPrice { get; set;}

        public bool ValidateChocolateFlavour()
        {
            if(Flavour.Equals("Dark") || Flavour.Equals("Milk") || Flavour.Equals("White"))
            {
                return true;
            }
            return false;
        }

    }
}
