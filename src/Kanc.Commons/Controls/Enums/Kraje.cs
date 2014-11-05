using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Commons
{
    public enum Kraje
    {
        [EnumDescription("brak")]
        brak = 0,
        [EnumDescription("Polska")]
        PL = 1,
        [EnumDescription("Niemcy")]
        DE = 2,
        [EnumDescription("Holandia")]
        NL = 3,
        [EnumDescription("Austria")]
        AT = 4
    }

    public enum KrajeBanki
    {
        [EnumDescription("brak")]
        brak = 0,
        [EnumDescription("Polska")]
        PL = 1,
        [EnumDescription("Niemcy")]
        DE = 2,
        [EnumDescription("Holandia")]
        NL = 3,
        [EnumDescription("Austria")]
        AT = 4,
        //[EnumDescription("Czechy")]
        //CZ = 6,
        [EnumDescription("Włochy")]
        IT = 5
    }

}

