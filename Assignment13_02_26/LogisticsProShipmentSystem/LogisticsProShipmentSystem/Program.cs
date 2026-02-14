using System;
namespace LogisticsProShipmentSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input ID: ");
            string id = Console.ReadLine();
            ShipmentDetails shipmentDetails = new ShipmentDetails();
            if (!shipmentDetails.ValidateShipmentCode(id))
            {
                Console.WriteLine("Invalid shipment code");
                return;
            }
            else
            {
                Console.Write("Mode: ");
                string mode = Console.ReadLine();
                Console.Write("Weight: ");
                double weight = Double.Parse(Console.ReadLine());
                Console.Write("Storage: ");
                int storage = Int32.Parse(Console.ReadLine());
                shipmentDetails.ShipmentCode = id;
                shipmentDetails.TransportMode = mode;
                shipmentDetails.Weight = weight;
                shipmentDetails.StorageDays = storage;
                Console.WriteLine($"The total shipping cost is {shipmentDetails.CalculateTotalCost():0.00}");
            }
        }
    }

}
