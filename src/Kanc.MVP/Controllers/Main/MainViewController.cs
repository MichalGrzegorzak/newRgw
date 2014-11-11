using System;
using System.Collections.Generic;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Engine.ViewManager;
using Kanc.MVP.Presentation.Client;
using Kanc.MVP.Presentation.MainForm;
using Kanc.MVP.Presentation.Note;
using Kanc.MVP.Presentation.Task;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Views;

namespace Kanc.MVP.Controllers
{
    public class MainViewController : ControllerBase<MainTask, IMainView>, IMyTaskResultListener
    {
        private Dictionary<Type, ITask> tasks = new Dictionary<Type, ITask>();

        /// <summary>
        /// Fired from left navigation bar
        /// </summary>
        public void NavigateToView(string viewName)
        {
            Task.Navigator.Navigate(viewName);
        }

        public void NavigateDirectlyTo(string viewName)
        {
            Task.Navigator.NavigateDirectly(viewName);
        }

        /// <summary>
        /// Fired from toolbar
        /// </summary>
        public void CreateView(ViewCategory vc)
        {
            IViewsManager vm = Task.Navigator.ViewsManager;
            InteractionPointInfoEx ip = (vm as IDynamicViewsManager).CreateView(vc);
            (View as IMainView).AddViewToNavPane(ip);
        }

        public void StartSearch()
        {
            StartSubTask<SearchTask>();
        }
        public void RecieveTaskResult(params object[] item)
        {
            Task.CurrentCustomer = item[0] as Customer;
            Task.CurrentOrder = item[1] as Order;

            View.LoadAvailableActions(false);
            View.ShowViewCategory(ViewCategory.Klient);

            Task.Navigator.NavigateDirectly(MainTask.EditOrder);

            //Task.TasksManager.StartTask(typeof(EditOrderTask),
            //    new object[] { Task, Task.CurrentOrder, Task.CurrentCustomer });
        }

        /// <summary>
        /// Start/resume task
        /// </summary>
        public void StartSubTask<TT>() where TT : MyTaskBase
        {
            Type taskType = typeof(TT);
            var resultListener = this as IMyTaskResultListener;

            if (!tasks.ContainsKey(taskType))
                tasks[taskType] = Task.TasksManager.StartTask(taskType, new object[] { Task, resultListener });
            else
                tasks[taskType].OnStart(null);
        }
        
    }
}
