using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Engine.ViewManager;
using Kanc.MVP.Presentation.Client;
using Kanc.MVP.Presentation.MainForm;
using Kanc.MVP.Presentation.Note;
using Kanc.MVP.Presentation.Task;
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
    }
}
