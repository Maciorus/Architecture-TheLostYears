using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLostYears.Core.Model.Requests;
using TheLostYears.Core.Model.Responses;

namespace TheLostYears.Core.Boundaries
{
    public interface IOrderBoundary
    {
        ISearchForOrderResult SearchForOrder(ISearchForOrderRequest request);

        ICreateOrderResult CreateOrder(ICreateOrderRequest request);

        IUpdateOrderResult UpdateOrder(IUpdateOrderRequest request);

        IPayForOrderResult PayForOrder(IPayForOrderRequest request);
    }
}
