using System;
using System.Text.RegularExpressions;
namespace String2_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the username");
            string word = Console.ReadLine();

            if (word.Length != 8)
            {
                Console.WriteLine("Invalid username");
                return;
            }
            else
            {
                string last = word.Substring(word.Length - 3, 3);
                string first = word.Substring(0, 5);
                bool upper4 = Regex.IsMatch(first, @"[A-Z]{4}[@]{1}");
                if (upper4)
                {
                    int lasts;
                    if (int.TryParse(last, out lasts))
                    {
                        if (lasts >= 101 && lasts <= 115)
                        {
                            string pass = word.Substring(0, 4);
                            int sum = 0;
                            for(int i=0;i<4;i++)
                            {
                                sum += (int)pass[i];
                            }
                            Console.WriteLine("Password: TECH"+ "_" + sum);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                    return;
                }
            }

        }
    }
}
