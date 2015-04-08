using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    [Serializable]
    public class Order
    {
        public DateTime OrderTime = DateTime.MinValue;
        public string CarType = "";
        public string DriverName = "";
        public string CarNumber = "";
        public DateTime PickUpTime = DateTime.MinValue;
        public string ClientName = "";
        public DateTime DeliveryTime = DateTime.MinValue;
        public Decimal Price = 0;
        public string OrderedBy = "";

    }
}
