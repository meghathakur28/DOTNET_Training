using System;
using System.Collections.Generic;
using System.Text;

namespace ShopValidator
{
    public class GadgetValidatorUtil
    {
        public Boolean validateGadgetID(string gadgetID)
        {
            int strt = (int)gadgetID[0];
            if (strt >= 65 && strt <= 90)
            {
                if (gadgetID.Length == 4)
                {
                    return true;
                }
            }
            throw new InvalidGadgetException("Invalid gadget ID");
        }

        public Boolean validateWarrantyPeriod(int period)
        {
            if (period >= 6 && period <= 36) return true;
            throw new InvalidGadgetException("Invalid warranty period");
        }
    }
}
