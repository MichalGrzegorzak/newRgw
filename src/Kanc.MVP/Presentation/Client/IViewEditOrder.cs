using System.Collections.Generic;
using Kanc.MVP.Domain;

namespace Kanc.MVP.Presentation.Client
{
    public interface IViewEditOrder
    {
        //void SetCustomerOrders(IList<Order> orders);
        //void SetCustomers(IList<Customer> customers);

        //int SelectedCustomerIndex { get; }
        //Order CurrentOrder { get; }

        int Id { get; set; }
        string Desc { get; set; }
        string Owner { get; set; }
        string Message { get; set; }

        void Close();


    }
}
