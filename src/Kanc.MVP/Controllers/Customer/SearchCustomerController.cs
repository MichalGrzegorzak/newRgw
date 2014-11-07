using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Client;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class SearchCustomerController : ControllerBase<MainTask, ISearchCustomer>
    {
        public List<Customer> FoundCustomers = new List<Customer>();

        public override ISearchCustomer View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                //View.SetCustomers(Customer.AllCustomers);
                //View.SelectedCustomer = Task.CurrentCustomer;
                Task.CurrentCustomerChanged += Task_CurrentCustomerChanged;
            }
        }

        /// <summary>
        ///     Update orders
        /// </summary>
        void Task_CurrentCustomerChanged(object sender, System.EventArgs e)
        {
            View.Nazwisko = Task.CurrentCustomer.Name;
            View.SetCustomerOrders(Task.CurrentCustomer.Orders);
        }

        public void CurrentCustomerChanged()
        {
            var selectedUser = FoundCustomers[View.SelectedCustomerIndex];
            Task.CurrentCustomer = selectedUser;
        }

        public void CurrentOrderChanged()
        {
            Task.CurrentOrder = View.CurrentOrder;
            
            //Task.Navigator.Navigate(MainTask.Orders);
            Task.TasksManager.StartTask(typeof (EditOrderTask),
                new object[] { Task, Task.CurrentOrder, Task.CurrentCustomer });
        }

        public void NewOrder()
        {
            Order order = new Order(-1, "");
            //Task.CurrentCustomer.Orders.Add(order);

            //Task.Navigator.Navigate(MainTask.Orders);
            Task.TasksManager.StartTask(typeof(EditOrderTask),
                new object[] { Task, order, Task.CurrentCustomer });
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

        //public void ShowOrders()
        //{
        //    Task.Navigator.Navigate(MainTask.Orders);
        //}

        
    }
}
