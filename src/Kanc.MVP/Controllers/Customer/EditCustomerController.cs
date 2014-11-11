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
    public class EditCustomerController : SubControllerBase<IBaseEditCustomersView>
    {
        public override void ViewActivated()
        {
            if (View.IsNew)
            {
                ResetView(); //executed whenever NewCustomer action is clicked
            }
        }

        public override void BindModel()
        {
            var c = Task.CurrentCustomer;

            ResetView();
            View.Id = c.Id;
            View.NazwiskoPl = c.Name;
            View.Age = c.Age;
        }

        public void ResetView()
        {
            View.Message = "";
            View.Id = 0;
            View.Age = 0;
            View.NazwiskoPl = "";
        }

        public override bool IsValid()
        {
            Errors = new List<string>();
            
            var c = Task.CurrentCustomer;
            if (c.Id < 1)
            {
                Errors.Add("Id can`t be 0");
                return false;
            }

            return true;
        }

        public override void Next()
        {
            //uwaga - edycja przez referencje
            var c = Task.CurrentCustomer;
            c.Name = View.NazwiskoPl;

            if (!c.Orders.Any())
            {
                Order o = new Order(0, "");
                c.Orders.Add(o);
                Task.CurrentOrder = o;
            }

            //Task.Navigator.Navigate(MainTask.EditOrder);
            base.Next();
            Task.FireCustomerChanged();
        }
        public override void Previous()
        {
            base.Previous();
        }

    }
}
