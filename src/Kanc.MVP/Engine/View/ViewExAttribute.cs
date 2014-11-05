﻿using System;
using MVCSharp.Core.Configuration.Views;

namespace Kanc.MVP.Engine.View
{
    public class ViewExAttribute : ViewAttribute
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
