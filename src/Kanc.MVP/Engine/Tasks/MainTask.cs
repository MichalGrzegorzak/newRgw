using System;
using Kanc.MVP.Controllers;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.Navigator;
using Kanc.MVP.Engine.View;
using MVCSharp.Core;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Tasks;

namespace Kanc.MVP.Engine.Tasks
{
    [Task(typeof(NavigatorEx))]
    public class MainTask : MyTaskBase
    {
        [IPointEx(ViewCategory.None, typeof(MainViewController))]
        public const string MainView = "MainView";
        [IPointEx(ViewCategory.None, typeof(MainViewEmptyController))]
        public const string MainViewEmpty = "MainViewEmpty";

        //[IPointEx(ViewCategory.None, typeof(SearchFormController), true)]
        //public const string SearchCustomer = "SearchForm";

        [IPointEx(ViewCategory.Klient, typeof(NewCustomerController), true)]
        public const string NewCustomer = "NewCustomer";

        [IPointEx(ViewCategory.NowyKlient, typeof(EditCustomerController), false)]
        public const string EditCustomer = "EditCustomer";

        [IPointEx(ViewCategory.Klient, typeof(EditOrderController), false)]
        public const string EditOrder = "EditOrder";

        
        

        //[InteractionPoint(typeof(CustomersController), true)]
        //[IPointEx(ViewCategory.Klient, typeof(CustomerController), true)]
        //public const string Customers = "Customers";

        //[IPointEx(ViewCategory.Klient, typeof(OrderController), true)]
        //public const string Orders = "Orders";



        private Customer currentCustomer = Customer.AllCustomers[0];
        public event EventHandler CurrentCustomerChanged;
        public Customer CurrentCustomer
        {
            get { return currentCustomer; }
            set
            {
                currentCustomer = value;
                FireCustomerChanged();
            }
        }
        public void FireCustomerChanged()
        {
            if (CurrentCustomerChanged != null)
                CurrentCustomerChanged(this, EventArgs.Empty);
        }

        private Order currentOrder = null;
        public event EventHandler CurrentOrderChanged;
        public Order CurrentOrder
        {
            get { return currentOrder; }
            set
            {
                currentOrder = value;
                FireOrderChanged();
            }
        }
        public void FireOrderChanged()
        {
            if (CurrentOrderChanged != null)
                CurrentOrderChanged(this, EventArgs.Empty);
        }

        [IPointEx(ViewCategory.None, typeof(ControllerBase))]
        public const string MailSendingSuccessView = "MailSendingSuccessView";

        [IPointEx(ViewCategory.None, typeof(ControllerBase))]
        public const string MailSendingFailureView = "MailSendingFailureView";

        [IPointEx(ViewCategory.Druki)]
        public const string PinnedNote = "Pinned Note";

        public override void OnStart(object param)
        {
            Navigator.NavigateDirectly(MainView);
        }
    }
}
