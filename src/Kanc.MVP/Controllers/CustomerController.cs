using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class CustomerController : ControllerBase<MainTask, ICustomersView>
    {
        public override ICustomersView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                View.SetCustomersList(Customer.AllCustomers);
                View.CurrentCustomer = Task.CurrentCustomer;
            }
        }

        public void ShowOrders()
        {
            Task.Navigator.Navigate(MainTask.Orders);
        }

        public void CurrentCustomerChanged()
        {
            Task.CurrentCustomer = View.CurrentCustomer;
        }
    }
}
