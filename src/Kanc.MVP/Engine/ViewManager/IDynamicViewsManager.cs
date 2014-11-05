using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Presentation.MainForm;

namespace Kanc.MVP.Engine.ViewManager
{
    public interface IDynamicViewsManager
    {
        InteractionPointInfoEx CreateView(ViewCategory vc);
        void RegisterMasterView(MainForm form);
    }
}
