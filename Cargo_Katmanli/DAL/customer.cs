using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class customer
    {
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerAdres { get; set; }
        public string CustomerPhone { get; set; }
        public decimal CustomerPayment { get; set; }
        public int shipmentNo { get; set; }
    }
}
