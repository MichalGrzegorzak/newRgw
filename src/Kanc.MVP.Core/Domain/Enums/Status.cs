using Utils.Features.ExtendentEnum;

namespace Kanc.MVP.Core.Domain
{
    public enum Status
    {
        [EnumDescription("braki")]
        braki = 88,

        [EnumDescription("do zapłaty")]
        doZaplaty = 63,

        [EnumDescription("czekam na liste")]
        czekamLista = 65,

        [EnumDescription("wysłane")]
        wyslane = 100,

        s680 = 680,
        s77 = 77,
        s99 = 99,
        s333 = 333,
        s62 = 62,
        s70 = 70,
        s90 = 90,

        s66 = 66, //nie mam pojecia

        //776 - ?
        //777

    }
}
