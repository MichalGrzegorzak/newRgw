using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Search;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers.Customer
{
    public class SearchCustomerController : ControllerBase<SearchTask, ISearchCustomer>
    {
        public List<Domain.Customer> FoundCustomers = new List<Domain.Customer>();

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
            Domain.Order order = new Domain.Order(-1, "");
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

            FoundCustomers = Domain.Customer.AllCustomers.Where(x => x.Name.StartsWith(View.Nazwisko)).ToList();
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
