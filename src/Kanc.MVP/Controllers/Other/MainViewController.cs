using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Engine.ViewManager;
using Kanc.MVP.Presentation.MainForm;
using MVCSharp.Core;
using MVCSharp.Core.Views;

namespace Kanc.MVP.Controllers
{
    public class MainViewController : ControllerBase
    {
        public void NavigateToView(string viewName)
        {
            Task.Navigator.Navigate(viewName);
        }

        public void CreateView(ViewCategory c)
        {
            IViewsManager vm = Task.Navigator.ViewsManager;
            InteractionPointInfoEx ip = (vm as IDynamicViewsManager).CreateView(c);
            (View as IMainView).AddViewToNavPane(ip);
        }
    }
}
