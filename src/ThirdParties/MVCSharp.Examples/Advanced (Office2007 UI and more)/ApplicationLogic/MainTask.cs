using MVCSharp.Core;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Tasks;

namespace Customization.ApplicationLogic
{
    [Task(typeof(NavigatorEx))]
    public class MainTask : TaskBase
    {
        [IPointEx(ViewCategory.None, typeof(MainViewController))]
        public const string MainView = "MainView";

        [IPointEx(ViewCategory.Mail, typeof(NewMailPropertiesViewController))]
        public const string NewMailPropertiesView = "New Mail Properties";

        [IPointEx(ViewCategory.None, typeof(ControllerBase))]
        public const string MailSendingSuccessView = "MailSendingSuccessView";

        [IPointEx(ViewCategory.None, typeof(ControllerBase))]
        public const string MailSendingFailureView = "MailSendingFailureView";

        [IPointEx(ViewCategory.Notes)]
        public const string PinnedNote = "Pinned Note";
        
        public override void OnStart(object param)
        {
            Navigator.NavigateDirectly(MainView);
        }
    }
}
