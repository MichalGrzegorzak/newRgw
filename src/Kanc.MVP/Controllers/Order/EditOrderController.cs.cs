using System;
using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Client;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class EditOrderController : ControllerBase<MainTask, IEditOrderView>
    {
        //public List<Customer> FoundCustomers = new List<Customer>();
        public override MainTask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                Task.CurrentOrderChanged += Task_CurrentOrderChanged;
            }
        }

        void Task_CurrentOrderChanged(object sender, EventArgs e)
        {
            BindModel(Task.CurrentOrder);
        }

        public override IEditOrderView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                BindModel(Task.CurrentOrder);
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
            var ord = Task.CurrentOrder;

            //uwaga - edycja przez referencje
            ord.Id = View.Id;
            ord.Desc = View.Desc;
            ord.Ship();

            var c = Task.CurrentCustomer;
            c.Orders.Add(ord);
            Task.CurrentCustomer = c;
            
            Task.Navigator.Navigate(MainTask.EditCustomer);
                //NavigateBack();
        }

        public void Cancel()
        {
            //View.Message = "Wystapil blad";
            //Task.OriginatingTask.OnStart(null);
            
            //Task.Navigator.Navigate(MainTask.SearchCustomer);
            Task.Navigator.NavigateBack();
        }

        
    }
}
