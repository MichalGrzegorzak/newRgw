using Kanc.MVP.Engine.InteractionPoint;

namespace Kanc.MVP.Presentation.MainForm
{
    public interface IMainView
    {

        void LoadAvailableActions(bool takeOnlyCommonTargets);
        void AddViewToNavPane(InteractionPointInfoEx ip);
        void CurrentCategoryChanged(string catName);

        void Refresh();
    }
}
