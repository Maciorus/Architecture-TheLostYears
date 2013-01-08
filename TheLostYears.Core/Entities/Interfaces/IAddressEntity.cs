using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostYears.Core.Entities.Interfaces
{
    public interface IAddressEntity : IEntity
    {
        int Id {get; set;}

        string AddressLine1 { get; set; }
        
        string AddressLine2 { get; set; }

        string Town { get; set; }

        string PostCode { get; set; }

        string Country { get; set; }
    }
}
