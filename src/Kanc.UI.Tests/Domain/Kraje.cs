using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.UI.Tests;

namespace Kanc.UI.Tests
{
    public enum Kraje
    {
        [EnumDescriptionAttribute("brak")]
        brak = 1,
        [EnumDescriptionAttribute("Polska")]
        PL = 2,
        [EnumDescriptionAttribute("Niemcy")]
        DE = 3,
        [EnumDescriptionAttribute("Holandia")]
        NL = 4,
        [EnumDescriptionAttribute("Austria")]
        AU = 5,
        [EnumDescriptionAttribute("Czechy")]
        CZ = 6,
        [EnumDescription("Włochy")]
        IT = 7
    }

}

