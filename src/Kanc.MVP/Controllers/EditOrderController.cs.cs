using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Client;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class EditOrderController : ControllerBase<TaskEditOrder, IViewEditOrder>
    {
        //public List<Customer> FoundCustomers = new List<Customer>();

        public override IViewEditOrder View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                BindModel(Task.Order);
                //View.SetCustomer(Customer.AllCustomers);
                //View.SelectedCustomer = Task.CurrentCustomer;
            }
        }

        private void BindModel(Order order)
        {
            View.Message = "";

            View.Id = order.Id;
            View.Desc = order.Desc;
            //View.Owner = 
        }

        //public void CurrentOrderChanged()
        //{
        //    Task.CurrentOrder = View.CurrentOrder;
        //    Task.Navigator.Navigate(MainTask.Orders);
        //}

        //public void CurrentCustomerChanged()
        //{
        //    var selectedUser = FoundCustomers[View.SelectedCustomerIndex];
        //    Task.CurrentCustomer = selectedUser;
        //    View.SetCustomerOrders(selectedUser.Orders);
        //}

        private void ResetView()
        {
            //View.EventsAllowed = false;
            View.Message = "";
            //View.Name = "";
            //View.SelectedCustomer
        }

        //private void EnableView()
        //{
        //    View.EventsAllowed = true;
        //}

        //public void Search()
        //{
        //    FoundCustomers = Customer.AllCustomers.Where(x => x.Name.StartsWith(View.Nazwisko)).ToList();
        //    if (FoundCustomers.Any())
        //    {
        //        View.SetCustomers(FoundCustomers);
        //        CurrentCustomerChanged();
        //    }
        //    else
        //    {
        //        View.Message = "Nie znaleziono usera";
        //    }
        //}

        public void Save()
        {
            var ord = Task.Order;
            ord.Id = View.Id;
            ord.Desc = View.Desc;
            ord.Ship();
            
            //SAVE

            Task.OriginatingTask.CurrentOrder = ord;
            Task.OriginatingTask.OnStart(null);
        }

        public void Cancel()
        {
            Task.OriginatingTask.OnStart(null);
            //Task.Navigator.Navigate(MainTask.Orders);
        }

        
    }
}
