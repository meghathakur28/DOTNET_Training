using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsProShipmentSystem
{
    public class Shipment
    {
        public string ShipmentCode {  get; set; }
        public string TransportMode {  get; set; }
        public double Weight { get; set; }
        public int StorageDays {  get; set; }
    }
}
