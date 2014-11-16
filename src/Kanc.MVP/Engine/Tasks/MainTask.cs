using System;
using Kanc.MVP.Controllers.Customer;
using Kanc.MVP.Controllers.Main;
using Kanc.MVP.Controllers.Order;
using Kanc.MVP.Core.Domain;
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
        [IPointEx(ViewCategory.None, typeof(MainViewController), false, NavTargets = new[] { NewCustomer, EditCustomer })]
        public const string MainView = "MainView";
        [IPointEx(ViewCategory.None, typeof(MainViewEmptyController))]
        public const string MainViewEmpty = "MainViewEmpty";

        //[IPointEx(ViewCategory.None, typeof(SearchFormController), true)]
        //public const string SearchCustomer = "SearchForm";

        [IPointEx(ViewCategory.NowyKlient, typeof(EditCustomerController), true, NavTargets = new[] { EditOrder })]
        public const string NewCustomer = "NewCustomer";
        [IPointEx(ViewCategory.Klient, typeof(EditCustomerController), false, NavTargets = new[] { EditOrder })]
        public const string EditCustomer = "EditCustomer";

        [IPointEx(ViewCategory.Klient, typeof(EditOrderController), false, NavTargets = new[] { EditCustomer })]
        public const string EditOrder = "EditOrder";

        //[InteractionPoint(typeof(CustomersController), true)]
        //[IPointEx(ViewCategory.Klient, typeof(CustomerController), true)]
        //public const string Customers = "Customers";

        //[IPointEx(ViewCategory.Klient, typeof(OrderController), true)]
        //public const string Orders = "Orders";

        //private OsobaLookup _currentOsobaLookup = OsobaLookup.AllCustomers[0];
        //public event EventHandler CurrentCustomerChanged;
        //public OsobaLookup CurrentOsobaLookup
        //{
        //    get { return _currentOsobaLookup; }
        //    set
        //    {
        //        _currentOsobaLookup = value;
        //        FireCustomerChanged();
        //    }
        //}
        //public void FireCustomerChanged()
        //{
        //    if (CurrentCustomerChanged != null)
        //        CurrentCustomerChanged(this, EventArgs.Empty);
        //}

        private Rozliczenie _currentRozliczenie = new Rozliczenie();
        public event EventHandler CurrentOrderChanged;
        public Rozliczenie CurrentRozliczenie
        {
            get { return _currentRozliczenie; }
            set
            {
                _currentRozliczenie = value;
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
