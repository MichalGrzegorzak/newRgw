using System;
using System.Windows.Forms;
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
    public class EditOrderTask : TaskBase
    {
        

        //private Customer currentCustomer = Customer.AllCustomers[0];
        //public event EventHandler CurrentCustomerChanged;
        //public Customer CurrentCustomer
        //{
        //    get { return currentCustomer; }
        //    set
        //    {
        //        currentCustomer = value;
        //        if (CurrentCustomerChanged != null)
        //            CurrentCustomerChanged(this, EventArgs.Empty);
        //    }
        //}

        //private Order currentOrder = null;
        //public event EventHandler CurrentOrderChanged;
        //public Order CurrentOrder
        //{
        //    get { return currentOrder; }
        //    set
        //    {
        //        currentOrder = value;
        //        if (CurrentOrderChanged != null)
        //            CurrentOrderChanged(this, EventArgs.Empty);
        //    }
        //}
        
        public MainTask OriginTask;
        public Order Order;
        public Customer Customer;
        //public ITask OriginatingTask;
        //public bool IsWorkerOfTheMonth = false;
        //public bool SpecialServices = false;

        public override void OnStart(object param)
        {
            OriginTask = (param as object[])[0] as MainTask;
            Order = (param as object[])[1] as Order;
            Customer = (param as object[])[2] as Customer;
            

            //OriginatingTask.CurrentCustomerChanged += CurrentCustomerChanged;

            //little hacking
            var frm = OriginTask.Navigator.ViewsManager.GetView(MainTask.MainView) as MainForm;
            ((IDynamicViewsManager)Navigator.ViewsManager).RegisterMasterView(frm);


            Navigator.ActivateView(EditOrder);
            //Navigator.NavigateDirectly(EditOrder);
        }
    }
}
