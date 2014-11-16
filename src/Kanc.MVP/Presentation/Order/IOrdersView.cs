using System.Collections.Generic;
using Kanc.MVP.Core.Domain;

namespace Kanc.MVP.Presentation.Order
{
    public interface IOrdersView
    {
        void SetOrdersList(List<Rozliczenie> orders);
        
        Rozliczenie CurrentRozliczenie
        {
            get;
        }

        void SetOperationsEnabling(bool AcceptIsEnabled, bool ShipIsEnabled, bool CancelIsEnabled);
    }
}
