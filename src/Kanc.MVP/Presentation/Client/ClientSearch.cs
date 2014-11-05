using System;
using Kanc.MVP.Controllers;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Client
{
    [ViewEx(typeof(MainTask), MainTask.NewMailPropertiesView, "New")]
    public partial class ClientSearch : WinUserControlView_For_MailController, IClientSearch
    {
        public ClientSearch()
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

    public class WinUserControlView_For_MailController : WinUserControlView<ClientController>
    { }
}
