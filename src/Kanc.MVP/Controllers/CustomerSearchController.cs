using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Client;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class CustomerSearchController : ControllerBase<MainTask, IClientSearch>
    {
        public List<Customer> FoundCustomers = new List<Customer>();

        public override IClientSearch View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                //View.SetCustomers(Customer.AllCustomers);
                //View.SelectedCustomer = Task.CurrentCustomer;
            }
        }

        public void CurrentOrderChanged()
        {
            Task.CurrentOrder = View.CurrentOrder;
            Task.Navigator.Navigate(MainTask.Orders);
        }

        public void CurrentCustomerChanged()
        {
            var selectedUser = FoundCustomers[View.SelectedCustomerIndex];
            Task.CurrentCustomer = selectedUser;
            View.SetCustomerOrders(selectedUser.Orders);
        }

        private void ResetView()
        {
            View.EventsAllowed = false;

            View.Message = "";
            //View.Name = "";
            //View.SelectedCustomer
        }

        private void EnableView()
        {
            View.EventsAllowed = true;
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

            EnableView();
        }

        public void ShowOrders()
        {
            Task.Navigator.Navigate(MainTask.Orders);
        }

        
    }
}
