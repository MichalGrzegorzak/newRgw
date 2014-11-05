using System;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Winforms.Configuration;

namespace Kanc.MVP.Engine.View
{
    public class ViewInfoEx : WinformsViewInfo
    {
        private string imgName;

        public ViewInfoEx(string viewName, string imgName, Type viewType)
            : base(viewName, viewType)
        {
            this.imgName = imgName;
        }

        public static ViewInfoEx Create(WinformsViewInfo vi, string imgName)
        {
            var r = new ViewInfoEx(vi.ViewName, imgName, vi.ViewType);
            r.IsMdiParent = vi.IsMdiParent;
            r.MdiParent = vi.MdiParent;
            r.ShowModal = vi.ShowModal;
            return r;
        }

        public string ImgName
        {
            get { return imgName; }
            set { imgName = value; }
        }
    }
}
