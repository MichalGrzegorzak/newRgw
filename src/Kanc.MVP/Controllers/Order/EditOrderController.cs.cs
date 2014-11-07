using System;
using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Client;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class EditOrderController : ControllerBase<EditOrderTask, IEditOrderView>
    {
        //public List<Customer> FoundCustomers = new List<Customer>();

        public override IEditOrderView View
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

        private void ResetView()
        {
            //View.EventsAllowed = false;
            View.Message = "";
            //View.Name = "";
            //View.SelectedCustomer
        }

        public void Save()
        {
            var ord = Task.Order;

            //uwaga - edycja przez referencje
            ord.Id = View.Id;
            ord.Desc = View.Desc;
            ord.Ship();

            var c = Task.OriginTask.CurrentCustomer;
            c.Orders.Add(ord);
            Task.OriginTask.CurrentCustomer = c;
            //Task.OriginatingTask.CurrentCustomerChanged(this, EventArgs.Empty);

            
            //Task.OriginatingTask.OnStart(null);
            
            //Task.OriginTask.Navigator.Navigate(MainTask.SearchCustomer);
            Task.OriginTask.Navigator.NavigateBack();
        }

        public void Cancel()
        {
            //View.Message = "Wystapil blad";
            //Task.OriginatingTask.OnStart(null);
            Task.Navigator.Navigate(MainTask.SearchCustomer);
        }

        
    }
}
