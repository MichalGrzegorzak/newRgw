using System.Collections.Generic;
using System.Linq;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Client;
using Kanc.MVP.Presentation.Customers;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class NewCustomerController : EditCustomerController
    {
        public void Activate()
        {
        
        }


        public void Save()
        {
            Customer c = new Customer("");
            c.Name = View.NazwiskoPl;
            c.Age = View.Age;

            //save
            Task.CurrentCustomer = c;
            Customer.AllCustomers.Add(c);

            Order o = new Order(-1, "");
            Task.CurrentOrder = o;
            
            //Task.TasksManager.StartTask(typeof(EditOrderTask),new object[] { Task, o, Task.CurrentCustomer });
            Task.Navigator.Navigate(MainTask.EditOrder);
        }

        public void Cancel()
        {
            //View.Message = "Wystapil blad";
            //Task.OriginatingTask.OnStart(null);
            Task.Navigator.Navigate(MainTask.MainViewEmpty);
        }


        
    }
}
