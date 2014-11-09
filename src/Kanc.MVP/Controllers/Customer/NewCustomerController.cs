using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Client;
using Kanc.MVP.Presentation.Customers;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class NewCustomerController : ControllerBase<MainTask, INewCustomersView>
    {
        public override INewCustomersView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
            }
        }

        public void Save()
        {
            Customer c = new Customer("");
            c.Name = View.Name;

            //save
            Task.CurrentCustomer = c;
            Customer.AllCustomers.Add(c);

            Order o = new Order(-1, "");
            
            Task.TasksManager.StartTask(typeof(EditOrderTask),
                new object[] { Task, o, Task.CurrentCustomer });
        }

        public void Cancel()
        {
            //View.Message = "Wystapil blad";
            //Task.OriginatingTask.OnStart(null);
            Task.Navigator.Navigate(MainTask.MainViewEmpty);
        }

        //public void CurrentOrderChanged()
        //{
        //    Task.CurrentOrder = View.CurrentOrder;
            
        //    //Task.Navigator.Navigate(MainTask.Orders);
        //    Task.TasksManager.StartTask(typeof (EditOrderTask), 
        //        new object[] {Task.CurrentOrder, Task});
        //}

        //public void CurrentCustomerChanged()
        //{
        //    var selectedUser = FoundCustomers[View.SelectedCustomerIndex];
        //    Task.CurrentCustomer = selectedUser;
        //    View.SetCustomerOrders(selectedUser.Orders);
        //}

        //private void ResetView()
        //{
        //    //View.EventsAllowed = false;
        //    View.Message = "";
        //    //View.Name = "";
        //    //View.SelectedCustomer
        //}

        //public void Search()
        //{
        //    ResetView();

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

        //public void ShowOrders()
        //{
        //    Task.Navigator.Navigate(MainTask.Orders);
        //}

        
    }
}
