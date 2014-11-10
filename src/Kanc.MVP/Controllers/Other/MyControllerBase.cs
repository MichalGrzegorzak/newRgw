using System;
using System.ComponentModel;
using Kanc.MVP.Engine.Tasks;
using MVCSharp.Core;

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

        public virtual void Initialize()
        {
            
        }
    }
}