using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core.Entities;

namespace Kanc.UI.Ctrl
{
    //public class ucBase : BaseUserControl, ICanAttachNavig
    //{
    //    public Database db { get; set; }

    //    public virtual void LoadData(Database db)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public virtual void AttachNavig(BindingNavigator navig)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public interface ICanAttachNavig
    {
        //Database db { get; }
        //void LoadData(Database db);
        void AttachNavig(BindingNavigator navig);

    }
}
