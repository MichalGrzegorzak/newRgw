using System;
using Kanc.MVP.Controllers.Customer;
using Kanc.MVP.Core.Domain;
using Kanc.MVP.Core.nHibernate.SessionProviders;
using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.Navigator;
using Kanc.MVP.Engine.View;
using MVCSharp.Core;
using MVCSharp.Core.Configuration.Tasks;
using NHibernate;

namespace Kanc.MVP.Engine.Tasks
{
    [Task(typeof(NavigatorEx))]
    public class SearchTask : MyTaskBase
    {
        [IPointEx(ViewCategory.None, typeof(ControllerBase), true)]
        public const string Start = "Start";

        [IPointEx(ViewCategory.None, typeof(SearchCustomerController), true)]
        public const string SearchCustomer = "Search";

        private OsobaLookup _currentOsobaLookup = new OsobaLookup(); //OsobaLookup.AllCustomers[0]);
        public event EventHandler CurrentCustomerChanged;
        public OsobaLookup CurrentOsobaLookup
        {
            get { return _currentOsobaLookup; }
            set
            {
                _currentOsobaLookup = value;
                if (CurrentCustomerChanged != null)
                    CurrentCustomerChanged(this, EventArgs.Empty);
            }
        }

        private Rozliczenie _currentRozliczenie = null;
        public event EventHandler CurrentOrderChanged;
        public Rozliczenie CurrentRozliczenie
        {
            get { return _currentRozliczenie; }
            set
            {
                _currentRozliczenie = value;
                if (CurrentOrderChanged != null)
                    CurrentOrderChanged(this, EventArgs.Empty);
            }
        }

        

        public override void OnStart(object param)
        {
            base.OnStart(param);

            //var frm = OriginatingTask.Navigator.ViewsManager.GetView(MainTask.MainView) as MainForm;
            //((IDynamicViewsManager)Navigator.ViewsManager).RegisterMasterView(frm);

            Navigator.ActivateView(Start);
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
