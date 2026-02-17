using System;
using System.Collections.Generic;
using System.Text;

namespace E_commerceShoppingCart
{
    public class ShoppingCart<T> where T : Product
    {
        private Dictionary<T, int> _cartItems = new Dictionary<T, int>();

        // Add product to cart
        public void AddToCart(T product, int quantity)
        {
            if(_cartItems.ContainsKey(product))
            {
                _cartItems[product] += quantity;
            }
            else
            {
                _cartItems.Add(product, 1);
            }
        }

        // Calculate total with discount delegate
        public double CalculateTotal(Func<T, double, double> discountCalculator = null)
        {
            double total = 0;
            foreach (var item in _cartItems)
            {
                double price = item.Key.Price * item.Value;
                if (discountCalculator != null)
                    price = discountCalculator(item.Key, price);
                total += price;
            }
            return total;
        }

        // Get top N expensive items using LINQ
        public List<T> GetTopExpensiveItems(int n)
        {
            var orderlist = _cartItems.OrderByDescending(x => x.Key.Price).Select(x=>x.Key).Take(n).ToList();
            return orderlist;
        }
    }

}
