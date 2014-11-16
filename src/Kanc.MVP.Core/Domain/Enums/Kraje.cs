using Utils.Features.ExtendentEnum;

namespace Kanc.MVP.Core.Domain
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

