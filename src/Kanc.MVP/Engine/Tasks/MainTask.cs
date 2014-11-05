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
    public class MainTask : TaskBase
    {
        //[IPointEx(ViewCategory.Mail, typeof(NewMailPropertiesViewController))]
        //[IPointEx(ViewCategory.Klient, typeof(ClientController))]
        //public const string NewMailPropertiesView = "New Mail Properties";

        //[InteractionPoint(typeof(CustomersController), true)]
        [IPointEx(ViewCategory.Klient, typeof(CustomerController), true)]
        public const string Customers = "Customers";
        [IPointEx(ViewCategory.Klient, typeof(OrderController), true)]
        public const string Orders = "Orders";



        private Customer currentCustomer = Customer.AllCustomers[0];

        public event EventHandler CurrentCustomerChanged;
        public Customer CurrentCustomer
        {
            get { return currentCustomer; }
            set
            {
                currentCustomer = value;
                if (CurrentCustomerChanged != null)
                    CurrentCustomerChanged(this, EventArgs.Empty);
            }
        }

        [IPointEx(ViewCategory.None, typeof(MainViewController))]
        public const string MainView = "MainView";

        

        [IPointEx(ViewCategory.None, typeof(ControllerBase))]
        public const string MailSendingSuccessView = "MailSendingSuccessView";

        [IPointEx(ViewCategory.None, typeof(ControllerBase))]
        public const string MailSendingFailureView = "MailSendingFailureView";

        [IPointEx(ViewCategory.Raporty)]
        public const string PinnedNote = "Pinned Note";
        
        public override void OnStart(object param)
        {
            Navigator.NavigateDirectly(MainView);
        }
    }
}
