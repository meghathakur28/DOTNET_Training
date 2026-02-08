using System;
using System.Collections.Generic;
using System.Text;

namespace End_To_End_25
{
    public class Order
    {
        public int OrderId {  get; set; }
        public double TotalPrice {  get; set; }
        public List<Product> Products { get; set; }
    }
}
