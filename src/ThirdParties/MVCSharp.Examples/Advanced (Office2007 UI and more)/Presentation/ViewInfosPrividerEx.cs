using System;
using MVCSharp.Core.Configuration.Views;

namespace Customization.Presentation
{
    public class ViewInfosPrividerEx : DefaultViewInfosProvider
    {
        protected override ViewInfo newViewInfo(Type viewType, ViewAttribute vAtr)
        {
            return new ViewInfoEx(vAtr.ViewName,
                  (vAtr as ViewExAttribute).ImgName, viewType);
        }
    }
}
