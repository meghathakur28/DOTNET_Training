using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArchDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentDAO daoObj = new StudentDAO();
            List<Student> ls  = daoObj.SearchByName("megha");
            if (ls.Count > 0)
            {
                foreach (var iten in ls)
                {
                    Console.WriteLine($"{iten.Name}\t{iten.RollNo}");
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
    }
}
