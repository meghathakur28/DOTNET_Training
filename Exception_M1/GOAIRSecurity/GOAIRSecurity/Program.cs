using System;
namespace GOAIRSecurity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of entries");
            int noEntry = Int32.Parse(Console.ReadLine());
            EntityUtility user = new EntityUtility();
            for (int i = 0; i < noEntry; i++)
            {
                Console.WriteLine($"Enter entry {i + 1} details");
                string entry = Console.ReadLine();

                Console.WriteLine("Enter the entries: ");
                int duration = Int32.Parse(Console.ReadLine());
                try
                {
                    if (user.validateEmployeeID(entry) && user.validateDuration(duration))
                    {
                        Console.WriteLine("Valid entry details");
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry details");
                    }
                }
                catch (InvalidEntryException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

}