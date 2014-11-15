using Kanc.MVP.Model;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers.Other
{
    public class NewMailPropertiesViewController : ControllerBase
    {
        public void SetNewMailSenderAddress(string address)
        {
            Mail.NewMailSenderAddress = address;
        }
    }
}
