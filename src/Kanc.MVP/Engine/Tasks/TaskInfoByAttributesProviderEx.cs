using Kanc.MVP.Engine.InteractionPoint;
using MVCSharp.Core.Configuration.Tasks;

namespace Kanc.MVP.Engine.Tasks
{
    public class TaskInfoByAttributesProviderEx : TaskInfoByAttributesProvider
    {
        protected override InteractionPointInfo CreateInteractionPointInfo(
                           string viewName, InteractionPointAttribute ipAttribute)
        {
            InteractionPointInfoEx result = new InteractionPointInfoEx();
            result.ViewName = viewName;
            result.ControllerType = ipAttribute.ControllerType;
            result.IsCommonTarget = ipAttribute.IsCommonTarget;
            result.ViewCategory = (ipAttribute as IPointExAttribute).ViewCategory;
            return result;
        }
    }
}
