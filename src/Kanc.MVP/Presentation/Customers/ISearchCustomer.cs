using System.Collections.Generic;
using Kanc.MVP.Domain;

namespace Kanc.MVP.Presentation.Customers
{
    public interface ISearchCustomer
    {
        void SetCustomerOrders(IList<Order> orders);

        void SetCustomers(IList<Customer> customers);

        int SelectedCustomerIndex { get; }
        Order CurrentOrder { get; }
        //bool EventsAllowed { set; }

        string Nazwisko { get; set; }
        string Message { get; set; }

        void RefreshView();
        void Close();

    }
}
