using System;
namespace SugarBlissBakery
{
    public class Program
    {
        public static Chocolate CalculateDiscountedPrice(Chocolate chocolate)
        {
            int discount = 0;
            if(chocolate.Flavour.Equals("Dark"))
            {
                discount = 18;
            }
            else if(chocolate.Flavour.Equals("Milk"))
            {
                discount = 12;
            }
            else if(chocolate.Flavour.Equals("White"))
            {
                discount = 6;
            }
            double totalPrice = chocolate.PricePerUnit * chocolate.Quantity;
            chocolate.TotalPrice = totalPrice;
            double discountedPrice = (totalPrice - (discount * totalPrice/100));
            chocolate.DiscountedPrice = discountedPrice;
            return chocolate;
        }
        public static void Main(string[] args)
        {
            Chocolate chocolate = new Chocolate();
            Console.WriteLine("Enter the chocolate flavour: ");
            chocolate.Flavour = Console.ReadLine();

            Console.WriteLine("Enter the Quantity: ");
            chocolate.Quantity = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price Per Unit: ");
            chocolate.PricePerUnit = Int32.Parse(Console.ReadLine());

            if (!chocolate.ValidateChocolateFlavour())
            {
                Console.WriteLine("Invalid flavour");
            }
            else
            {
                Chocolate choco = CalculateDiscountedPrice(chocolate);
                Console.WriteLine("Flavour: " + choco.Flavour);
                Console.WriteLine("Quantity: " + choco.Quantity);
                Console.WriteLine("Price Per Unit: " + choco.PricePerUnit);
                Console.WriteLine("Total Price: " + choco.TotalPrice);
                Console.WriteLine("Discounted Price: " + choco.DiscountedPrice);
            }
        }
    }
}