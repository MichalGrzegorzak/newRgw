using System;
using Kanc.MVP.Controllers;
using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.View;
using MVCSharp.Core;

namespace Kanc.MVP.Engine.Navigator
{
    public class NavigatorEx : MVCSharp.Core.Navigator
    {
        public override IController GetController(string viewName)
        {
            IController result = base.GetController(viewName);
            if (result != null) return result;

            InteractionPointInfoEx ip = TaskInfo.InteractionPoints[viewName]
                                                  as InteractionPointInfoEx;
            Type cType = null;
            switch (ip.ViewCategory)
            {
                case ViewCategory.Klient: cType = typeof(CustomerController); break;
                case ViewCategory.Raporty: cType = typeof(NoteController); break;
                case ViewCategory.Tasks: cType = typeof(TaskController); break;
            }
            ip.ControllerType = cType;
            return base.GetController(viewName);            
        }
    }
}
