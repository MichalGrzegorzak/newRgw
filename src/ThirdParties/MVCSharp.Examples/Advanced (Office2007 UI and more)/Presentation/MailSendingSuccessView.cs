using System;
using Customization.ApplicationLogic;
using MVCSharp.Winforms;

namespace Customization.Presentation
{
    [ViewEx(typeof(MainTask), MainTask.MailSendingSuccessView, "")]
    public partial class MailSendingSuccessView : WinFormView
    {
        public MailSendingSuccessView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}