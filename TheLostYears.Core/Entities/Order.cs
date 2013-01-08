using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLostYears.Core.Entities.Interfaces;

namespace TheLostYears.Core.Entities
{
    public class Order : IOrderEntity
    {
        public ICustomerEntity Customer { get; set; }

        public IAddressEntity DeliveryAddress { get; set; }

        public IList<string> Products { get; set; }

        public decimal OrderTotal { get; set; }
    }
}
