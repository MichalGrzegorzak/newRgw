using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Client;
using Kanc.MVP.Presentation.Customers;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class EditCustomerController : ControllerBase<MainTask, IEditCustomersView>
    {
        public override IEditCustomersView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                //View.SetCustomers(Customer.AllCustomers);
                //View.SelectedCustomer = Task.CurrentCustomer;
            }
        }

        public void Save()
        {
            //uwaga - edycja przez referencje
            var c = Task.CurrentCustomer;
            c.Name = View.Name;

            Task.FireCustomerChanged();
            Task.Navigator.Navigate(MainTask.EditOrder);
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
