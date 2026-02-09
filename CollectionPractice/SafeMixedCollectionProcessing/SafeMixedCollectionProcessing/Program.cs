using System;
using System.Collections;
namespace SafeMixedCollectionProcessing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // store element of different datatype
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(20);
            arrayList.Add(2.34);
            arrayList.Add("meghathakur");

            //extract only integer values
            List<int> list = new List<int>();
            foreach(var i in  arrayList)
            {
                int ints;
                if(Int32.TryParse(i.ToString(),out ints))
                {
                    list.Add(ints*ints);
                }
            }

            int sum = 0;
            foreach(var i in  list)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of the integers : {sum}");




        }
    }
}
