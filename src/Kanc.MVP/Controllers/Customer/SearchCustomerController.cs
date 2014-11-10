using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Client;
using Kanc.MVP.Presentation.Customers;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class SearchCustomerController : ControllerBase<SearchTask, ISearchCustomer>
    {
        public List<Customer> FoundCustomers = new List<Customer>();

        public void CurrentCustomerChanged()
        {
            var selectedUser = FoundCustomers[View.SelectedCustomerIndex];
            
            Task.CurrentCustomer = selectedUser;
            View.SetCustomerOrders(selectedUser.Orders);
            View.RefreshView();
        }

        public void CurrentOrderChanged()
        {
            Task.CurrentOrder = View.CurrentOrder;
            UserHasSelectedOrder();
        }

        /// <summary>
        /// Finalize task - return value
        /// </summary>
        public void UserHasSelectedOrder()
        {
            Task.TaskResultListener.RecieveTaskResult(Task.CurrentCustomer, Task.CurrentOrder);
            View.Close();
        }

        public void NewOrder()
        {
            Order order = new Order(-1, "");
            Task.CurrentOrder = order;

            UserHasSelectedOrder();
        }

        private void ResetView()
        {
            View.Message = "";
            //View.Name = "";
            //View.SelectedCustomer
        }

        public void Search()
        {
            ResetView();

            FoundCustomers = Customer.AllCustomers.Where(x => x.Name.StartsWith(View.Nazwisko)).ToList();
            if (FoundCustomers.Any())
            {
                View.SetCustomers(FoundCustomers);
                CurrentCustomerChanged();
            }
            else
            {
                View.Message = "Nie znaleziono usera";
            }
        }
        
    }
}
