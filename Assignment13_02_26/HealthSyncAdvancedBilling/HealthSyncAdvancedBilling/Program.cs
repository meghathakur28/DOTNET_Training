using System;
using System.Text.RegularExpressions;
namespace HealthSyncAdvancedBilling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Id: ");
            string Id = Console.ReadLine();

            if(!ValidateConsultantId(Id))
            {
                Console.WriteLine("Invalid doctor Id (Process terminates).");
            }

            Console.WriteLine("Enter the Stipend: ");
            double stipend = Double.Parse(Console.ReadLine());
        }
        public static bool ValidateConsultantId(string Id)
        {
            if (Id.Length == 6)
            {
                bool val = Regex.IsMatch(Id, @"[D R]{2} [0-9]{4}");
                if(val)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
