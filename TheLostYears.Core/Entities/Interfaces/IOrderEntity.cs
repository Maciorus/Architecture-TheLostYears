using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostYears.Core.Entities.Interfaces
{
    public interface IOrderEntity : IEntity
    {
        ICustomerEntity Customer { get; set; }

        IAddressEntity DeliveryAddress { get; set; }

        IList<string> Products { get; set; }

        decimal OrderTotal { get; set; }
    }
}
