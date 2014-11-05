using System;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class OrderController : ControllerBase<MainTask, IOrdersView>
    {
        public override MainTask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                Task.CurrentCustomerChanged += CurrentCustomerChanged;
            }
        }

        public override IOrdersView View
        {
            get {return base.View; }
            set
            {
                base.View = value;
                CurrentCustomerChanged(Task, EventArgs.Empty);
            }
        } 

        private void CurrentCustomerChanged(object sender, EventArgs e)
        {
            View.SetOrdersList(Task.CurrentCustomer.Orders);
            UpdateView();
        }

        public void AcceptOrder()
        {
            View.CurrentOrder.Accept();
            UpdateView();
        }

        public void ShipOrder()
        {
            View.CurrentOrder.Ship();
            UpdateView();
        }

        public void CancelOrder()
        {
            View.CurrentOrder.Cancel();
            UpdateView();
        }

        public void CurrentOrderChanged()
        {
            UpdateView();
        }

        private void UpdateView()
        {
            if (View.CurrentOrder == null) return;
            OrderState os = View.CurrentOrder.State;
            View.SetOperationsEnabling(
                    os == OrderState.Open, os == OrderState.Pending,
                    (os == OrderState.Open) || (os == OrderState.Pending));
        }

        public void ShowCustomers()
        {
            Task.Navigator.Navigate(MainTask.SearchCustomer);
        }
    }
}
