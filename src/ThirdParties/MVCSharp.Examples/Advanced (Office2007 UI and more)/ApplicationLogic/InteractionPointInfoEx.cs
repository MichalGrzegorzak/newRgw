using MVCSharp.Core.Configuration.Tasks;

namespace Customization.ApplicationLogic
{
    public class InteractionPointInfoEx : InteractionPointInfo
    {
        private ViewCategory viewCat;

        public ViewCategory ViewCategory
        {
            get { return viewCat; }
            set { viewCat = value; }
        }
    }
}
