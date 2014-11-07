using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;

namespace Kanc.MVP.Presentation.Client
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

