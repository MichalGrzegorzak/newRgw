using Customization.Model;
using MVCSharp.Core;

namespace Customization.ApplicationLogic
{
    public class NewMailPropertiesViewController : ControllerBase
    {
        public void SetNewMailSenderAddress(string address)
        {
            Mail.NewMailSenderAddress = address;
        }
    }
}
