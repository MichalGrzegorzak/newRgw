using System;
using Kanc.MVP.Engine.View;
using MVCSharp.Core.Configuration.Tasks;

namespace Kanc.MVP.Engine.InteractionPoint
{
    public class IPointExAttribute : IPointAttribute
    {
        private ViewCategory viewCat;

        public IPointExAttribute(ViewCategory viewCat, Type controllerType,
                                                       bool isCommonTarget)
                                    : base(controllerType, isCommonTarget)
        {
            this.viewCat = viewCat;
        }

        public IPointExAttribute(ViewCategory viewCat, Type controllerType)
            : this(viewCat, controllerType, true) { }

        public IPointExAttribute(ViewCategory viewCat)
            : this(viewCat, null) { }

        public ViewCategory ViewCategory
        {
            get { return viewCat; }
            set { viewCat = value; }
        }
    }
}
