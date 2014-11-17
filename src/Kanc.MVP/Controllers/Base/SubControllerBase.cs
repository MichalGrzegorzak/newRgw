using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.Validator;
using Kanc.MVP.Presentation.Customers;

namespace Kanc.MVP.Controllers.Base
{
    public class SubControllerBase<TView> : MyControllerBase<MainTask, TView>
        where TView : class, IMyBaseView
    {
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
        protected virtual void Task_CurrentOrderChanged(object sender, EventArgs e)
        {
        }
        protected virtual void Task_CurrentCustomerChanged(object sender, EventArgs e)
        {
        }
        
        public override TView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                ViewInitialized();
                BindModel();
            }
        }
        public virtual void ViewInitialized()
        {
        }
        public virtual void ViewActivated()
        {
        }
        public virtual void BindModel()
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
            Task.Navigator.Navigate("NEXT");
            Task.FireOrderChanged();
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
    }
}