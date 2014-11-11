using System.Collections.Generic;
using Kanc.MVP.Domain;

namespace Kanc.MVP.Controllers
{
    public interface IOrdersView
    {
        void SetOrdersList(List<Order> orders);
        
        Order CurrentOrder
        {
            get;
        }

        void SetOperationsEnabling(bool AcceptIsEnabled, bool ShipIsEnabled, bool CancelIsEnabled);
    }
}
