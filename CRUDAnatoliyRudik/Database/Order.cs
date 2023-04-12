using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatoliyRudik.Database
{
    public class Order
    {
        public int Id { get; set; }

        public Package Package { get; set; }
        public Client Client { get; set; }
        public Operator Operator { get; set; }
        public Tariff Tariff { get; set; }
        public TransportDelivery Delivery { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
