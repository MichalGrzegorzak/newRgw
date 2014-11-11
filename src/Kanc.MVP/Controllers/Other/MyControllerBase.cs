using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Kanc.MVP.Engine.Tasks;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class SubControllerBase<TView> : MyControllerBase<MainTask, TView>
        where TView : class
    {
        public override MainTask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                Task.CurrentCustomerChanged += Task_CurrentCustomerChanged;
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
        public virtual bool IsValid()
        {
            Errors = new List<string>(); //you should do
            return true;
        }

        public virtual void Next()
        {
            if (IsValid())
                Task.Navigator.Navigate("NEXT");
            else
            {
                //TODO -> View.NotifyUser(dialog);
                string delimeter = " \n";
                MessageBox.Show("Please correct errors: \n"
                                + Errors.Aggregate((i, j) => i + delimeter + j));
            }
                
        }
        public virtual void Previous()
        {
            Task.Navigator.NavigateBack();//.Navigate(MainTask.MainViewEmpty);
        }
    }


    public class MyControllerBase<TTask, TView> : ControllerBase<TTask, TView>
        where TTask : MyTaskBase
        where TView : class
    {
        
        //public void StartSubTask<TT, Ret>()
        //    where TT : MyTaskBase
        //    where Ret : class
        //{
        //    Type taskType = typeof(TT);
        //    IMyTaskResultListener<Ret> resultListener = this as IMyTaskResultListener<Ret>;

        //    Task.TasksManager.StartTask(taskType, new object[] { Task, resultListener });
        //}
        public void StartSubTask<TT>() where TT : MyTaskBase
        {
            Type taskType = typeof(TT);
            var resultListener = this as IMyTaskResultListener;

            Task.TasksManager.StartTask(taskType, new object[] { Task, resultListener });
        }

        
    }
}