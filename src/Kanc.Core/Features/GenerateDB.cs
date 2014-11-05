using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FizzWare.NBuilder;
using Kanc.Commons;
using Kanc.Core.Entities;

namespace Kanc.Core.Features
{
    public class GenerateDBData
    {
        UniqueRandomGenerator genDate = new UniqueRandomGenerator();
        public static int UID = 0;

        public List<Rozliczenie> GenerateList(int maxItems)
        {
            //UID = startID;
            List<Rozliczenie> result = new List<Rozliczenie>();
            for (int i = 0; i <= maxItems; i++)
            {
                Rozliczenie r = CreateRozliczenie();
                r.Klient = CreateKlient(r);
                r.AdresRozliczenia = CreateAdres(r);
                r.Konto = CreateKonto(r);
                r.Partner = CreatePartner(r);
                r.Podatek = CreatePodatek(r);
                r.Rachunek = CreateRachunek(r);
                r.Historia = CreateHistoria(r);
                r.Kraj = Kraje.DE;
                r.Rok = 2005;
                r.Status = Status.braki;
                r.CreatedOn = DateTime.Now;
                r.ModifiedOn = DateTime.Now;
                result.Add(r);

                UID++;
            }
            return result;
        }

        public Rozliczenie CreateRozliczenie()
        {
            Rozliczenie r = Builder<Rozliczenie>.CreateNew()
                .With(x => x.Id = 0)
                .Do(x => InsertAdditionalNumberToAllStrings(x, UID))
                .Build();
            return r;
        }

        //private static void ForAllProp<T>(T mytype) where T : class
        //{
        //    var ff = typeof (T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        //    foreach (PropertyInfo info in ff)
        //    {
        //        //EntityAdv
        //        if(info.PropertyType.IsClass)
        //        {
        //            info.PropertyType.I
        //        }
        //    }
        //}

        //public static void ReplaceStrings<T>(List<T> list, string replacement)
        public static void InsertAdditionalNumberToAllStrings<T>(T listItem, int number)
        {
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo p in properties)
            {
                // Only work with strings
                if (p.PropertyType != typeof(string)) { continue; }

                // If not writable then cannot null it; if not readable then cannot check it's value
                if (!p.CanWrite || !p.CanRead) { continue; }

                MethodInfo mget = p.GetGetMethod(false);
                MethodInfo mset = p.GetSetMethod(false);

                // Get and set methods have to be public
                if (mget == null) { continue; }
                if (mset == null) { continue; }

                //foreach (T item in list)
                {
                    string val = (string)p.GetValue(listItem, null);
                    if (!string.IsNullOrEmpty(val) && val.EndsWith("1"))
                    {
                        string newValue = val + number;
                        p.SetValue(listItem, newValue, null);
                    }
                }
            }
        }

        public Historia CreateHistoria(Rozliczenie r)
        {
            Historia kkk = Builder<Historia>.CreateNew().WithConstructor(() => new Historia(r))
                .With(x => x.Id = 0)
                .Do(x => InsertAdditionalNumberToAllStrings(x, UID))
                .Build();
            return kkk;
        }

        public Rachunek CreateRachunek(Rozliczenie r)
        {
            Rachunek kkk = Builder<Rachunek>.CreateNew().WithConstructor(() => new Rachunek(r))
                .With(x => x.Id = 0)
                .Do(x => InsertAdditionalNumberToAllStrings(x, UID))
                .Build();
            return kkk;
        }

        public Podatek CreatePodatek(Rozliczenie r)
        {
            Podatek kkk = Builder<Podatek>.CreateNew().WithConstructor(() => new Podatek(r))
                .With(x => x.Id = 0)
                .Do(x => InsertAdditionalNumberToAllStrings(x, UID))
                .Build();
            return kkk;
        }

        public Partner CreatePartner(Rozliczenie r)
        {
            Partner kkk = Builder<Partner>.CreateNew().WithConstructor(() => new Partner(r))
                .With(x => x.Id = 0)
                .With(x => x.Urodz = NextDate())
                .With(x => x.MandId = NextInt().ToString())
                .Do(x => InsertAdditionalNumberToAllStrings(x, UID))
                .Build();
            return kkk;
        }

        public Konto CreateKonto(Rozliczenie r)
        {
            Konto kkk = Builder<Konto>.CreateNew().WithConstructor(() => new Konto(r))
                .With(x => x.Id = 0)
                .With(x => x.KontoLk = "22")
                .With(x => x.KontoNr = NextKontoNr())
                .With(x => x.BankBLZ = "123456")
                .Do(x => InsertAdditionalNumberToAllStrings(x, UID))
                .Build();
            return kkk;
        }

        public Adres CreateAdres(Rozliczenie r)
        {
            //.WithConstructor(() => new Adres(r))
            Adres adres = Builder<Adres>.CreateNew()
                .With(x => x.Id = 0)
                .Do(x => InsertAdditionalNumberToAllStrings(x, UID))
                .Build();
            return adres;
        }

        public Klient CreateKlient(Rozliczenie r)
        {
            Klient k = Builder<Klient>.CreateNew().WithConstructor(() => new Klient(r))
                .With(x => x.AdresZameld = CreateAdres(r))
                .With(x => x.Id = 0)
                .With(x => x.Urodz = NextDate())
                .With(x => x.DataSlubu = NextDate())
                .With(x => x.Telefon = "1234567890")
                .With(x => x.Komorka = "1234567890")
                .With(x => x.Email = "eee@o2.pl")
                .With(x => x.MandId = NextInt().ToString())
                .Do(x => InsertAdditionalNumberToAllStrings(x, UID))
                .Build();
            //k.Urodz = NextDate();
            //k.DataSlubu = NextDate();
            //k.Notka = "sadasd";
            //k.Plec = Plec.Mężczyzna;
            //k.Religia = 0;
            //k.Steuernummer = "121212";
            //k.Telefon = "12121212";
            //k.Zawod = "zawod";
            //k.Email = "1231111@o2.pl";
            //k.Imie = "imie1";
            //k.ImieDe = "imieDE1";
            //k.Nazwisko.
            return k;
        }

        private DateTime NextDate()
        {
            DateTime dt = genDate.Next(new DateTime(1955, 1, 1), DateTime.Now.Subtract(new TimeSpan(4745, 1, 0, 0)));
            //return dt;
            return dt.ToShortDateString().Parse<DateTime>();
        }

        private int NextInt()
        {
            return genDate.Next(1111, 9999);
        }

        private string NextKontoNr()
        {
            return genDate.Next(11, 99999999).ToString();
        }
    }
}
