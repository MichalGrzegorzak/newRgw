using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Customers;
using MVCSharp.Core;
using MVCSharp.Core.Views;

namespace Kanc.MVP.Controllers
{
    public interface ISearchFormView : IView
    {
        
    }

    public class SearchFormController : ControllerBase<MainTask, ISearchFormView>
    {
        public override ISearchFormView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                //Task.TasksManager.StartTask(typeof(SearchTask), new object[] { Task });
            }
        }
    }
}
