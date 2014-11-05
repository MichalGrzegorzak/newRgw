using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core;
using Kanc.Core.Entities;

namespace Kanc.Tests
{
    public abstract class EntitiesFactory
    {
        public static Bank MakeBank()
        {
            Bank bank = new Bank();
                //DataBindingFactory.Create<Bank>();
            bank.Nazwa = "sdfsa";
            bank.Swift = "123345";
            bank.Kraj = Kraje.PL;
            bank.Adres = "dsfds";
            bank.Blz = 1111;
            return bank;
        }

        public static Klient MakeKlient()
        {
            Klient k = new Klient();
                //DataBindingFactory.Create<Klient>();
            k.Urodz = new DateTime(1980, 11, 11);
            k.Plec = Plec.Mężczyzna;
            k.PoleconyPrzez = new Polecil();
                //DataBindingFactory.Create<Polecil>();
            k.PoleconyPrzez.Nazwa = "fsdf";
            return k;
        }

        public static Adres MakeAdres()
        {
            Adres a = new Adres();
                //DataBindingFactory.Create<Adres>();
            a.Kod = "58-260";
            a.Kraj = Kraje.PL;
            a.Miasto = "Bielawa";
            a.Miejsce = "";
            a.Ulica = "jakas 17";
            return a;
        }

        public static Rozliczenie MakeRozliczenie1()
        {
            Rozliczenie r = new Rozliczenie();
                //DataBindingFactory.Create<Rozliczenie>();
            r.MandId = "123";
            r.Rok = 2010;
            r.KontoNr = 123456768789000;
            r.KontoBlz = 1234;
            r.Kraj = Kraje.PL;
            r.Klient = MakeKlient();
            r.Imie = "imie1";
            r.Nazwisko = "nazwisko1";
            r.Komorka = "1";
            r.KontoBank = MakeBank();
            r.AdresKoresp = MakeAdres();
            r.AdresZameld = MakeAdres();
            r.Email = "elv@o2.pl";
            r.Komorka = "121232";
            return r;
        }
    }
}
