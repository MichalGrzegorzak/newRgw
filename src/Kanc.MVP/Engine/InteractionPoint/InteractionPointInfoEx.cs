using Kanc.MVP.Engine.View;
using MVCSharp.Core.Configuration.Tasks;

namespace Kanc.MVP.Engine.InteractionPoint
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
