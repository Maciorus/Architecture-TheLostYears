using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLostYears.Core.Model.Requests;
using TheLostYears.Core.Model.Responses;

namespace TheLostYears.Core.Boundaries
{
    public interface ICustomerBoundary
    {
        ICreateCustomerResult CreateCustomer(ICreateCustomerRequest request);

        IUpdateCustomerResult UpdateCustomer(IUpdateCustomerRequest request);

        ISearchForCustomerResult SearchForCustomer(ISearchForCustomerRequest request);

        IViewCustomerAddressesResult ViewCustomerAddresses(IViewCustomerAddressesRequest request);
    }
}
