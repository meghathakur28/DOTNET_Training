using System;
using System.Collections.Generic;
using System.Text;

namespace End_To_End_25
{
    public class OrderItem
    {
        public static List<Product> cart = new List<Product>();
        public bool AddProduct(Product product)
        {
            if(product.Quantity>0)
            {
                cart.Add(product);
                return true;
            }
            return false;
        }
        public bool RemoveProduct(Product product)
        {
            if(cart.Contains(product))
            {
                cart.Remove(product);
                return true;
            }
            return false;
        }

    }
}
