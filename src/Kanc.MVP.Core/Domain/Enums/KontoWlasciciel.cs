using Utils.Features.ExtendentEnum;

namespace Kanc.MVP.Core.Domain
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

