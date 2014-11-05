using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.UI.Tests.Core
{
    public abstract class Factory
    {
        public static Klient_A GetKlient()
        {
            Klient_A k = new Klient_A();
            //k.Id = 1;
            k.Urodz = new DateTime(1980, 11, 11);
            k.Name = "k";

            //k.KrajA = GetKraj();
            //k.KrajA.NazwaEU = "Poland";
            //k.KrajA.Name = "PL";
            return k;
        }

        //public static Kraj_A GetKraj()
        //{
        //    Kraj_A k = new Kraj_A();
        //    k.NazwaEU = "PL";
        //   // k.NazwaPL = "Polska";
        //    k.Name = "PL";
        //    return k;
        //}

        public static Rachunek_A GetRozliczenie1()
        {
            Rachunek_A r = new Rachunek_A();
            r.KlientA = GetKlient();
            r.Name = "imie z rachunku";
            return r;
        }

        //public static Rozliczenie GetRozliczenie2()
        //{
        //    Rozliczenie r = new Rozliczenie();
        //    r.Kraj_A = Kraje.DE;
        //    r.Klient = GetKlient();
        //    r.Imie = "imie2";
        //    r.Nazwisko = "nazwisko2";
        //    r.Komorka = "2";
        //    return r;
        //}

    }
}
