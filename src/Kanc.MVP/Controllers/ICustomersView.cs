using System.Collections.Generic;
using Kanc.MVP.Domain;

namespace Kanc.MVP.Controllers
{
    public interface ICustomersView
    {
        void SetCustomersList(List<Customer> customers);

        Customer CurrentCustomer
        {
            get;
            set;
        }
    }
}
