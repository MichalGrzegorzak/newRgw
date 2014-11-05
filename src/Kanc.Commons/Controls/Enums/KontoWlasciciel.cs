using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Commons
{
    public enum KontoWlasciciel
    {
        [EnumDescription("---")]
        brak = 0,
        [EnumDescription("Nazwisko polskie")]
        polskieNazwisko = 1,
        [EnumDescription("Nazwisko niemieckie")]
        niemieckieNazwisko = 2,
        [EnumDescription("Inny wlasciciel")]
        inny = 3,
    }
}

