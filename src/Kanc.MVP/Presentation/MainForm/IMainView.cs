using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.View;

namespace Kanc.MVP.Presentation.MainForm
{
    public interface IMainView
    {
        void LoadAvailableActions(bool takeOnlyCommonTargets);
        void AddViewToNavPane(InteractionPointInfoEx ip);
        void CurrentCategoryChanged(string catName);

        void ShowViewCategory(ViewCategory cat);

        void ShowOrHide(bool show);
    }
}
