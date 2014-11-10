using System;
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

    public class MainViewController : ControllerBase<MainTask, IView>, IMyTaskResultListener
    {
        public void NavigateToView(string viewName)
        {
            Task.Navigator.Navigate(viewName);
        }

        public void CreateView(ViewCategory vc)
        {
            IViewsManager vm = Task.Navigator.ViewsManager;

            //switch (vc)
            //{
            //    //    Task.TasksManager.StartTask(typeof(New))

            //    case ViewCategory.NowyKlient:
            //        vi.ImgName = "Mail"; vi.ViewType = typeof(NewCustomerView); break;
            //    case ViewCategory.Klient:
            //        vi.ImgName = "Mail"; vi.ViewType = typeof(SearchCustomer); break;
            //    case ViewCategory.Druki:
            //        vi.ImgName = "Notes"; vi.ViewType = typeof(NoteView); break;
            //    case ViewCategory.Tasks:
            //        vi.ImgName = "Tasks"; vi.ViewType = typeof(TaskView); break;                    
            //}

            InteractionPointInfoEx ip = (vm as IDynamicViewsManager).CreateView(vc);
            (View as IMainView).AddViewToNavPane(ip);
        }

        public void StartSearch()
        {
            StartSubTask<SearchTask>();
        }

        public void StartSubTask<TT>()
            where TT : MyTaskBase
        {
            Type taskType = typeof(TT);
            var resultListener = this as IMyTaskResultListener;

            Task.TasksManager.StartTask(taskType, new object[] { Task, resultListener });
        }
        public void RecieveTaskResult(params object[] item)
        {
            Task.CurrentCustomer = item[0] as Customer;
            Task.CurrentOrder = item[1] as Order;

            Task.TasksManager.StartTask(typeof(EditOrderTask),
                new object[] { Task, Task.CurrentOrder, Task.CurrentCustomer });
        }
    }
}
