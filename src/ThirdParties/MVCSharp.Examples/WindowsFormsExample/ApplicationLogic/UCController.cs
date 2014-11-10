using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Views;
using MVCSharp.Core.Configuration.Views;

namespace MVCSharp.Examples.WindowsFormsExample.ApplicationLogic
{
    public class UCController : ControllerBase
    {
        public override ITask Task
        {
            get { return base.Task; }
            set
            {
                base.Task = value;
                //(Task as MainTask).CurrViewChanged += CurrViewChanged;
            }
        }

        public override IView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                //CurrViewChanged(Task, EventArgs.Empty);
            }
        }

        public void ShowModel()
        {
            MessageBox.Show("ok");
        }
    }
}
