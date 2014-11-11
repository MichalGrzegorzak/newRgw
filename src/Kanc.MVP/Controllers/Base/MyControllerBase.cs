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
        
        public void StartSubTask<TT>() where TT : MyTaskBase
        {
            Type taskType = typeof(TT);
            var resultListener = this as IMyTaskResultListener;

            Task.TasksManager.StartTask(taskType, new object[] { Task, resultListener });
        }
    }
}