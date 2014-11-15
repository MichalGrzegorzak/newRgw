using System;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation
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