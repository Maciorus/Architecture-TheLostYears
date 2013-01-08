using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLostYears.Core.Entities.Interfaces;

namespace TheLostYears.Core.Entities
{
    public class Address : IAddressEntity
    {
        public int Id { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Town { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }
    }
}
