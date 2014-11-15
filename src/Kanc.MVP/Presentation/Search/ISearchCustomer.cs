using System.Collections.Generic;
using Kanc.MVP.Domain;

namespace Kanc.MVP.Presentation.Search
{
    public interface ISearchCustomer
    {
        void SetCustomerOrders(IList<Domain.Order> orders);

        void SetCustomers(IList<Customer> customers);

        int SelectedCustomerIndex { get; }
        Domain.Order CurrentOrder { get; }
        //bool EventsAllowed { set; }

        string Nazwisko { get; set; }
        string Message { get; set; }

        void RefreshView();
        void Close();

    }
}
