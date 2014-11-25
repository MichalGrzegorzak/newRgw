using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Kanc.MVP.Core.nHibernate.SessionProviders;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.Validator;
using Kanc.MVP.Presentation.Customers;
using NHibernate;

namespace Kanc.MVP.Controllers.Base
{
    public class SubControllerBase<TView> : MyControllerBase<MainTask, TView>, ISubController
        where TView : class, IMyBaseView
    {
        /// <summary>
        /// Wykonuje sie tylko raz, przy utworzeniu kontrolera
        /// </summary>
        public override MainTask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                //Task.CurrentCustomerChanged += Task_CurrentCustomerChanged;
                Task.CurrentOrderChanged += Task_CurrentOrderChanged;
            }
        }
        /// <summary>
        /// Wykounje sie tylko raz, po utworzeniu View
        /// </summary>
        public override TView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                base.View.ViewName = Task.CurrViewName;

                ViewInitialized();
                BindModel();

            }
        }
        public virtual void ViewInitialized()
        {
        }
        public virtual void ViewActivated()
        {
            BindModel();
        }
        public virtual void BindModel()
        {
        }

        protected virtual void Task_CurrentOrderChanged(object sender, ViewChangedEventArgs e)
        {
            if (e.ViewName == View.ViewName) //aby nie bindowac drugi raz aktualnego View
                return;

            //obecnie robie Bindind przez ViewActivated ?
            //BindModel();
        }
        protected virtual void Task_CurrentCustomerChanged(object sender, ViewChangedEventArgs e)
        {
        }
        
        

        protected List<string> Errors = new List<string>();
        protected BasicValidator<TView> Validator = null;
        public void RegisterControlForValidation<TProperty>(Control control, Expression<Func<TView, TProperty>> expression)
        {
            Validator.For(expression, control.Name);
        }
        public virtual bool IsValid()
        {
            Errors = new List<string>(); //you should always do this
            return true;
        }
        public virtual void Save()
        {
        }

        public virtual void Next()
        {
            if (!IsValid())
            {
                ShowErrors();
                return;
            }

            Save();

            Task.FireOrderChanged(Task.CurrViewName); //poinformuj reszte formatek
            Task.Navigator.Navigate("NEXT");
            
        }
        public virtual void Previous()
        {
            Task.Navigator.NavigateBack();//.Navigate(MainTask.MainViewEmpty);
        }

        public virtual void ShowErrors()
        {
            string delimeter = " \n";
            string message = "View is not valid, please correct errors: \n";
            if (Errors.Any())
                message += Errors.Aggregate((i, j) => i + delimeter + j);
            else
                message = "- but you don`t have errors ??";

            View.NotifyUser(message);
        }

        #region nHibernate session - from Task
        public ISession Session
        {
            get { return Task.Session; }
        }
        private IStatelessSession _statelessSession;
        protected IStatelessSession StatelessSession
        {
            get { return Task.StatelessSession; }
        }
        #endregion

    }
}