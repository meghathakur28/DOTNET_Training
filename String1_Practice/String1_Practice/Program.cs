using System;
namespace String1_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence");
            string word = Console.ReadLine();
            string[] words = word.Split(" ");
            string ans = "";
                for(int i=words.Length-1; i>=0; i--)
                {
                    ans += words[i];
                    if(i!=0)
                    {
                        ans += " ";
                    }
                }
            if(words.Length%2!=0)
            {
                string rev = new string(ans.Reverse().ToArray());
                Console.WriteLine(rev);
                return;
            }
            Console.WriteLine(ans);
            
        }
    }
}
