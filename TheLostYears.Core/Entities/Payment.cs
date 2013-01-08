using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLostYears.Core.Entities.Interfaces;

namespace TheLostYears.Core.Entities
{
    public class Payment : IPaymentEntity
    {
        public int Id { get; set; }

        public IOrderEntity Order { get; set; }

        public IAddressEntity BillingAddress { get; set; }

        public decimal TotalPaid { get; set; }
    }
}
