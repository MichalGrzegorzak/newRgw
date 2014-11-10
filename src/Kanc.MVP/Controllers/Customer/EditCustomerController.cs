using System;
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
        public override MainTask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                Task.CurrentCustomerChanged += Task_CurrentCustomerChanged;
            }
        }

        void Task_CurrentCustomerChanged(object sender, EventArgs e)
        {
            BindModel(Task.CurrentCustomer);
        }
        public override IEditCustomersView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
            }
        }

        public void ResetView()
        {
            View.Message = "";
        }

        public void BindModel(Customer c)
        {
            ResetView();

            View.Name = c.Name;
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
            Task.Navigator.Navigate(MainTask.MainViewEmpty);
        }

    }
}
