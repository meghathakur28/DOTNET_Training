using System;
using System.Collections.Generic;
using System.Text;

namespace TechNovaRetailSolution
{
    public class Electronic:Product
    {
        public string Brand {  get; set; }
        public int WarrentyPeriod {  get; set; }
        public int PowerUsage {  get; set; }
        public DateTime ManufacturingDate {  get; set; }
    } 
}
