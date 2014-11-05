using Kanc.MVP.Model;
using MVCSharp.Core;

namespace Kanc.MVP.Controllers
{
    public class NewMailPropertiesViewController : ControllerBase
    {
        public void SetNewMailSenderAddress(string address)
        {
            Mail.NewMailSenderAddress = address;
        }
    }
}
