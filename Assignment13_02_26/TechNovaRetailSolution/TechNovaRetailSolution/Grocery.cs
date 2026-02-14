using System;
using System.Collections.Generic;
using System.Text;

namespace TechNovaRetailSolution
{
    public class Grocery:Product
    {
        public DateTime ExpiryDate {  get; set; }
        public int Weight { get; set; }
        public bool IsOrganic { get; set; }
        public int StorageTemperature {  get; set; }
    }
}
