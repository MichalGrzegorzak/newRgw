using System.Collections.Generic;

namespace Kanc.MVP.Presentation.Order
{
    public interface IOrdersView
    {
        void SetOrdersList(List<Domain.Order> orders);
        
        Domain.Order CurrentOrder
        {
            get;
        }

        void SetOperationsEnabling(bool AcceptIsEnabled, bool ShipIsEnabled, bool CancelIsEnabled);
    }
}
