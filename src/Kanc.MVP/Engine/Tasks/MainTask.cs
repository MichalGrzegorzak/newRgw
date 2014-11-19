using System;
using Kanc.MVP.Controllers.Customer;
using Kanc.MVP.Controllers.Main;
using Kanc.MVP.Controllers.Order;
using Kanc.MVP.Core.Domain;
using Kanc.MVP.Core.nHibernate.SessionProviders;
using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.Navigator;
using Kanc.MVP.Engine.View;
using MVCSharp.Core;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Tasks;
using NHibernate;

namespace Kanc.MVP.Engine.Tasks
{
    public class ViewChangedEventArgs : EventArgs
    {
        public ViewChangedEventArgs(string viewName)
        {
            ViewName = viewName;
        }

        public string ViewName { get; set; }    
    }

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
        public event EventHandler<ViewChangedEventArgs> CurrentOrderChanged;
        public Rozliczenie CurrentRozliczenie
        {
            get { return _currentRozliczenie; }
            set
            {
                _currentRozliczenie = value;
                FireOrderChanged(CurrViewName);
            }
        }
        public void FireOrderChanged(string currViewName)
        {
            if (CurrentOrderChanged != null)
                CurrentOrderChanged(this, new ViewChangedEventArgs(currViewName));
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

        #region nHibernate session
        private ISession _session;
        public ISession Session
        {
            get
            {
                if (_session == null)
                    _session = SqlSessionFactoryProvider.Instance.OpenSession();
                return _session;
            }
        }
        private IStatelessSession _statelessSession;
        public IStatelessSession StatelessSession
        {
            get
            {
                if (_statelessSession == null)
                    _statelessSession = SqlSessionFactoryProvider.Instance.OpenStatelessSession();
                return _statelessSession;
            }
        }

        public virtual void Dispose()
        {
            if (_session != null)
                _session.Dispose();
            if (_statelessSession != null)
                _statelessSession.Dispose();
        }
        #endregion
    }
}
