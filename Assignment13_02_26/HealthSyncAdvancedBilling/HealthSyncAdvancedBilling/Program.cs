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
                return;
            }
                Console.WriteLine("1. In-House Consultant");
                Console.WriteLine("2. Visiting");
                Console.Write("Enter your choice: ");
                int choice = Int32.Parse(Console.ReadLine());
                double netPayment = 0;
                switch (choice)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("Enter the stipend");
                            double stipend = double.Parse(Console.ReadLine());
                        MonthlyStipend monthlyStipend = new MonthlyStipend(stipend);

                        if (stipend> 5000)
                            {
                                
                                netPayment = (monthlyStipend.CalculateGrossPayout())-(monthlyStipend.CalculateGrossPayout()  * 0.15);
                            Console.WriteLine($"Gross: {monthlyStipend.CalculateGrossPayout():0.00} | TDS Applied: 15% | NetPayment: {netPayment:0.00} ");
                            }
                            else
                            {
                                netPayment = (monthlyStipend.CalculateGrossPayout())-(monthlyStipend.CalculateGrossPayout() * 0.05);
                            Console.WriteLine($"Gross: {monthlyStipend.CalculateGrossPayout():0.00} | TDS Applied: 5% | NetPayment: {netPayment:0.00} ");
                        }
                            break;
                        }
                    case 2:
                        {
                           
                            Console.WriteLine("Enter the no of visits: ");
                            int noOfVisits = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Rate: ");
                            double rate = double.Parse(Console.ReadLine());
                        Visiting visiting = new Visiting(noOfVisits,rate);
                        netPayment = visiting.CalculateGrossPayout() - visiting.CalculateGrossPayout()* 0.10;
                        Console.WriteLine($"Gross: {visiting.CalculateGrossPayout():0.00} | TDS Applied: 10% | NetPayment: {netPayment:0.00} ");
                        break;
                        }
                }
            
            }
        public static bool ValidateConsultantId(string Id)
        {
            if (Id.Length != 6) return false;
            if (!Id.StartsWith("DR")) return false;
            string numeric = Id.Substring(2);
            return int.TryParse(numeric, out _);
        }
    }
}
