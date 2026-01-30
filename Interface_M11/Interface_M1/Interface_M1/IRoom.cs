using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Interface_M1
{
    public interface IRoom
    {
        public double calculateTotalBill(int nightStayed, int joiningYear);
        public int calculateMembershipYears(int joiningYear);
    }
}
