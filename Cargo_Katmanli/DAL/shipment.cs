using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class shipment
    {
        public int shipmentNo { get; set; }
        public string shipmentName { get; set; }
        public string shipmentPickup { get; set; }
        public string shipmentTransport { get; set; }
        public int shipmentDistance { get; set; }
        public decimal shipmentAmount { get; set;}
        public int vehiclesNo { get; set;}
    }
}
