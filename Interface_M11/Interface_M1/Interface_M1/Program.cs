
using System;

namespace Interface_M1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Deluxe Room Details:");
            string roomType = "Deluxe";

            Console.Write("Guest Name: ");
            string guestName = Console.ReadLine();

            Console.Write("Rate Per Night: ");
            double ratePerNight = Double.Parse(Console.ReadLine());

            Console.Write("Night Stayed: ");
            int nightStayed = Int32.Parse(Console.ReadLine());

            Console.Write("Joining Year: ");
            int joiningYear = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Room Summary: ");
            HotelRoom room1 = new HotelRoom(roomType, ratePerNight, guestName);
            double bill = room1.calculateTotalBill(nightStayed, joiningYear);

            System.Console.WriteLine($"{room1.roomType}: {room1.guestName}, {room1.ratePerNight} per night, Membership: {room1.calculateMembershipYears(joiningYear)} years");

            Console.WriteLine($"For{room1.guestName} ({room1.roomType}): {bill}");








        }
    }
}
