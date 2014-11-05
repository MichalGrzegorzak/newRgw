using System;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Winforms.Configuration;

namespace Kanc.MVP.Engine.View
{
    public class ViewExAttribute : WinformsViewAttribute
    {
        private string imgName;

        public ViewExAttribute(Type taskType, string viewName, string imgName)
            : base(taskType, viewName)
        {
            this.imgName = imgName;
        }

        public string ImgName
        {
            get { return imgName; }
            set { imgName = value; }
        }
    }
}
