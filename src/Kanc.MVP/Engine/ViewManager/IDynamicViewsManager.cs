using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.View;

namespace Kanc.MVP.Engine.ViewManager
{
    public interface IDynamicViewsManager
    {
        InteractionPointInfoEx CreateView(ViewCategory vc);
    }
}
