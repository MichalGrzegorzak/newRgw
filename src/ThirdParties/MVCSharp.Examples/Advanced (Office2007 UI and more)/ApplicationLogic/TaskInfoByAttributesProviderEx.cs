using MVCSharp.Core.Configuration.Tasks;

namespace Customization.ApplicationLogic
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
