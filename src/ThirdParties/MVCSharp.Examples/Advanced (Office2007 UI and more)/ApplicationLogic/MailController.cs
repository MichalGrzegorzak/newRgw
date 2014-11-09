using Customization.Model;
using MVCSharp.Core;

namespace Customization.ApplicationLogic
{
    public class MailController : ControllerBase<MainTask, IMailView>
    {
        public void SendMail()
        {
            if (View.RecipientAddress.Length > 0 && View.SenderAddress.Length > 0)
                Task.Navigator.Navigate(MainTask.MailSendingSuccessView);
            else
                Task.Navigator.Navigate(MainTask.MailSendingFailureView);
        }

        public override IMailView View
        {
            get { return base.View; }
            set
            {
                base.View = value;
                View.SenderAddress = Mail.NewMailSenderAddress;
            }
        }
    }
}
