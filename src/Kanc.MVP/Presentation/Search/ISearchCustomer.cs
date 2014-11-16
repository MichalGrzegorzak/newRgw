using System.Collections.Generic;

using Kanc.MVP.Core.Domain;

namespace Kanc.MVP.Presentation.Search
{
    public interface ISearchCustomer
    {
        void SetCustomerOrders(IList<Rozliczenie> orders);

        void SetCustomers(IList<OsobaLookup> customers);

        int SelectedCustomerIndex { get; }
        Rozliczenie CurrentRozliczenie { get; }
        //bool EventsAllowed { set; }

        string Nazwisko { get; set; }
        string Message { get; set; }

        void RefreshView();
        void Close();

    }
}
