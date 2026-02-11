using System;
using System.Text.RegularExpressions;
namespace Regex_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // email checking 
            Console.WriteLine("Enter the email: ");
            String str = Console.ReadLine();
            bool validate = Regex.IsMatch(str,@"[A-Z a-z 0-9 _ . / \ - ]+[@ gmail.com]");
            Console.WriteLine(validate);

            // enter the phone number
            Console.WriteLine("Enter the phone number: ");
            string phoneNo = Console.ReadLine();
            bool validatePhone = Regex.IsMatch(phoneNo, @"[8 9 7 6][0-9]+");
            Console.WriteLine(validatePhone);
        }
    }

}
