using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_M1
{
    public class HotelRoom : IRoom
    {
        public string roomType { get; set; }
        public double ratePerNight { get; set; }
        public string guestName { get; set; }

        public HotelRoom(string roomType, double ratePerNight, string guestName)
        {
            this.roomType = roomType;
            this.ratePerNight = ratePerNight;
            this.guestName = guestName;
        }

        public double calculateTotalBill(int nightStayed, int joiningYear)
        {
            double bill = ratePerNight * nightStayed;

            if (joiningYear > 3) bill = (bill - (0.1 * bill));

            return bill;

        }

        public int calculateMembershipYears(int joiningYear)
        {
            DateTime d = DateTime.
            return joiningYear;
        }
    }
}
