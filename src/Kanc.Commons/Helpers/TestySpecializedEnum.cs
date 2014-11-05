using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Commons.Helpers
{
    public class StatusyTypes : SpecializedEnum<StatusyTypes, int>
    {
        public static readonly int mokey = 0;
        public static readonly int red = 12;
        public static readonly int wembley = 55;

        static StatusyTypes()
        {
            AddDesc(StatusyTypes.mokey, "opis1");
            AddDesc(StatusyTypes.red, "opis2");
        }
    }
}
