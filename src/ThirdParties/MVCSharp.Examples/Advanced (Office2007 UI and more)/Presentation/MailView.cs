using System;
using Customization.ApplicationLogic;
using MVCSharp.Winforms;

namespace Customization.Presentation
{
    public partial class MailView : WinUserControlView_For_MailController, IMailView
    {
        public MailView()
        {
            InitializeComponent();
        }

        public string RecipientAddress
        {
            get { return recipientTextBox.Text; }
        }

        public string SenderAddress
        {
            get { return senderTextBox.Text; }
            set { senderTextBox.Text = value; }
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            Controller.SendMail();
        }
    }

    public class WinUserControlView_For_MailController : WinUserControlView<MailController>
    { }
}
