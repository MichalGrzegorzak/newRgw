using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.MVP.Presentation.MainForm;
using MVCSharp.Core.Tasks;

namespace Kanc.MVP.Engine.Tasks
{
    public class MyTaskBase : TaskBase
    {
        public MainTask OriginTask { get; set; }
        public IMyTaskResultListener TaskResultListener;

        public override void OnStart(object param)
        {
            if(param == null) 
                return;

            OriginTask = (param as object[])[0] as MainTask;
            TaskResultListener = (param as object[])[1] as IMyTaskResultListener;
        }
    }

    public interface IMyTaskResultListener
    {
        void RecieveTaskResult(params object[] item);
    }

    //public interface IResultListener<T> : IMyTaskResultListener where T : class
    //{
    //    void RecieveTaskResult(object[] values);
    //    void RecieveResult(T item);
    //}

 

}
