using System;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Winforms.Configuration;

namespace Kanc.MVP.Engine.View
{
    public class ViewInfosPrividerEx : WinformsViewInfosProvider //DefaultViewInfosProvider
    {
        protected override ViewInfo newViewInfo(Type viewType, ViewAttribute vAtr)
        {
            string image = (vAtr as ViewExAttribute).ImgName;

            var result = (WinformsViewInfo)base.newViewInfo(viewType, vAtr);
            result = ViewInfoEx.Create(result, image);
            return result;
            //return new ViewInfoEx(vAtr.ViewName,, viewType);
        }
    }
}
