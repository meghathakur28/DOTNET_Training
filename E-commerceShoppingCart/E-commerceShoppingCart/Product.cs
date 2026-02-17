using System;
using System.Collections.Generic;
using System.Text;

namespace E_commerceShoppingCart
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
