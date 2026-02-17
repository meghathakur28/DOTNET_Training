using System;
namespace FindItems_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();

            Console.Write("Enter sold count to search: ");
            long soldCount = long.Parse(Console.ReadLine());

            var found = p.FindItemDetails(soldCount);
            if (found.Count == 0)
            {
                Console.WriteLine("Invalid sold count");
            }
            else
            {
                foreach (var kv in found)
                    Console.WriteLine($"{kv.Key} : {kv.Value}");
            }

            var minMax = p.FindMinandMaxSoldItems();
            if (minMax.Count >= 2)
                Console.WriteLine($"Min Sold Item: {minMax[0]}, Max Sold Item: {minMax[1]}");

            Console.WriteLine("Sorted by sold count:");
            var sorted = p.SortByCount();
            foreach (var kv in sorted)
                Console.WriteLine($"{kv.Key} : {kv.Value}");
        }
        public static SortedDictionary<String, long> itemDetails = new SortedDictionary<String, long>()
        {
             { "Pen", 120 },
            { "Pencil", 80 },
            { "Notebook", 250 },
            { "Eraser", 60 },
        };

        public SortedDictionary<String , long> FindItemDetails(long soldCount)
        {
            SortedDictionary<string, long> findItem = new SortedDictionary<string, long>();

            foreach (var item in itemDetails)
            {
                if(item.Value ==  soldCount)
                {
                    findItem.Add(item.Key, item.Value);
                }
            }
            return findItem;

        }

        public List<string> FindMinandMaxSoldItems()
        {
            List<string> list = new List<string>();
            string min = itemDetails.Select(x=>x.Key).Max();
            string max = itemDetails.Select(x=>x.Key).Min();
            list.Add(min);
            list.Add(max);
            return list;
        }

        public Dictionary<string, long> SortByCount()
        {
            var sorts = itemDetails.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return sorts;
        }
    }
}
