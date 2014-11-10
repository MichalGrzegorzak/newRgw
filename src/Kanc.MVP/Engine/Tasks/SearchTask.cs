using System;
using Kanc.MVP.Controllers;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.Navigator;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Engine.ViewManager;
using Kanc.MVP.Presentation.MainForm;
using MVCSharp.Core;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Tasks;

namespace Kanc.MVP.Engine.Tasks
{
    [Task(typeof(NavigatorEx))]
    public class SearchTask : MyTaskBase
    {
        [IPointEx(ViewCategory.None, typeof(ControllerBase), true)]
        public const string Start = "Start";

        [IPointEx(ViewCategory.None, typeof(SearchCustomerController), true)]
        public const string SearchCustomer = "Search";

        //[InteractionPoint(typeof(CustomersController), true)]
        //[IPointEx(ViewCategory.Klient, typeof(CustomerController), true)]
        //public const string Customers = "Customers";

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

        private Order currentOrder = null;
        public event EventHandler CurrentOrderChanged;
        public Order CurrentOrder
        {
            get { return currentOrder; }
            set
            {
                currentOrder = value;
                if (CurrentOrderChanged != null)
                    CurrentOrderChanged(this, EventArgs.Empty);
            }
        }

        //public MainTask OriginatingTask;
        
        public override void OnStart(object param)
        {
            //OriginatingTask = (param as object[])[0] as MainTask;
            base.OnStart(param);

            //OriginTask.CurrentCustomerChanged += CurrentCustomerChanged;
            //OriginTask.CurrentOrderChanged += CurrentOrderChanged;

            //var frm = OriginatingTask.Navigator.ViewsManager.GetView(MainTask.MainView) as MainForm;
            //((IDynamicViewsManager)Navigator.ViewsManager).RegisterMasterView(frm);


            Navigator.ActivateView(Start);
            //Navigator.NavigateDirectly(SearchCustomer);
        }
    }
}
