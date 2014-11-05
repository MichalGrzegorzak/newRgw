using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.UI.Forms.Base
{
    public interface ICurrentItem<T>
    {
        T CurrentItem { get; set; }
    }
}
