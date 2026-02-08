using System;
using System.Transactions;
namespace End_To_End_25
{
    public class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Mini Order System");
            Console.WriteLine("1. Add to Cart");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. Exit");
        }
        public static List<Product> products = new List<Product>()
            {
                new Product(){ProdId = 1, ProdName = "Kettle", Price = 400, Quantity = 4 },
                new Product(){ProdId = 2, ProdName = "Laptop", Price = 50000, Quantity = 12},
                new Product(){ProdId = 3, ProdName = "Charger", Price = 1200, Quantity = 1},
            };
        public static void Show()
        {
            foreach(var p in products)
            {
                Console.WriteLine("Id: "+p.ProdId+", Name: "+p.ProdName+", Price: "+p.Price+", Quantity: "+p.Quantity);
            }
        }
        public static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.CustId = 101;
            cust.Name = "Megha";
            cust.Address = "Himachal";
            cust.Region = "North";
            cust.PhoneNo = "6230661251";
            cust.City = "Hamirpur";

            double Price = 0;
            int choice = 0;
            while(choice != 3)
            {
                Menu();
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        {

                            OrderItem cart = new OrderItem();
                            int add = 1;
                            while (add != 0)
                            {
                                Show();
                                Console.WriteLine("Enter your choice: ");
                                int id = Int32.Parse(Console.ReadLine());
                                Product prod = products.Find(x => x.ProdId == id);
                                if (prod.Quantity == 0)
                                {
                                    Console.WriteLine("There is no stock of this product\n");
                                }
                                else
                                {
                                    prod.Quantity = prod.Quantity - 1;
                                    cart.AddProduct(prod);
                                    Price += prod.Price;
                                    Console.WriteLine("Successfully added the product in the Cart");
                                }
                                Console.WriteLine("Enter 0 if u want to exit");
                                add = Int32.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Existing the cart.....");
                            break;
                        }
                    case 2:
                        {
                            Payment payment = new Payment();
                            payment.PaymentId = 123456;
                            Console.WriteLine("Enter the Mode of the Payment");
                            Console.WriteLine("1. UPI Payment");
                            Console.WriteLine("2. Cash on Delivery");
                            payment.PaymentMode = Int32.Parse(Console.ReadLine());
                            payment.PaymentAmount = Price;
                            Console.WriteLine("Your payment amount is:" + payment.PaymentAmount);
                            Console.WriteLine("Add the coupon if u have any");
                            string Coupon = Console.ReadLine();
                            payment.IsCoupon = true;
                            if(payment.IsCoupon)
                            {
                                payment.PaymentAmount = payment.PaymentAmount * 0.1;
                                Console.WriteLine("Discounted Price: " + payment.PaymentAmount);
                            }
                            Console.WriteLine($"Payment Mode: {payment.PaymentMode}, Payment Amount: {payment.PaymentAmount}");
                            Console.WriteLine("Your order is delevired");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Thanyou for visiting");
                            break;
                        }
                }
            }
        }
    }
}


    