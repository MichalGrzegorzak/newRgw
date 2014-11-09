using Customization.ApplicationLogic;

namespace Customization.Presentation
{
    [ViewEx(typeof(MainTask), MainTask.MailSendingFailureView, "")]
    public partial class MailSendingFailureView : MailSendingSuccessView
    {
        public MailSendingFailureView()
        {
            InitializeComponent();
        }
    }
}

