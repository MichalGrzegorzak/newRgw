using System;
using System.ComponentModel;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using Kanc.Commons;
using NHibernate.Validator.Constraints;

namespace Kanc.Core.Entities
{
    [Serializable]
    public class Rozliczenie : EntityAdv
    {
        public Rozliczenie()
        {
            //Rachunek = DataBindingFactory.Create<Rachunek>();
            Klient = new Klient(this);
            Rachunek = new Rachunek(this);
            Podatek = new Podatek(this);
            
            Konto = new Konto(this);
            Partner = new Partner(this);
            Historia = new Historia(this);

            Kraj = new Kraje();
            Status = Status.braki; //domyslny
            AdresRozliczenia = new Adres();
        }

        public virtual int Rok { get; set; }
        public virtual Kraje Kraj { get; set; }
        public virtual Status Status { get; set; }
        public virtual int PoprzedniId { get; set; }

        public virtual Klient Klient { get; set; }
        public virtual Partner Partner { get; set; }
        public virtual Adres AdresRozliczenia { get; set; }
        public virtual Podatek Podatek { get; set; }
        public virtual Konto Konto { get; set; }
        public virtual Rachunek Rachunek { get; set; }
        public virtual Historia Historia { get; set; }

        
        //public override void EnableTracking()
        //{
        //    if (Rachunek != null) this.Rachunek.EnableTracking();
        //    if (Historia != null) this.Historia.EnableTracking();
        //    if (Podatek != null) this.Podatek.EnableTracking();
        //    if (Klient != null) this.Klient.EnableTracking();
        //    base.EnableTracking();
        //}

        public override object Clone()
        {
            Rozliczenie r = (Rozliczenie) MemberwiseClone();
            r.Id = 0;
            if (Klient != null) r.Klient = (Klient)Klient.Clone();
            if (Podatek != null) r.Podatek = (Podatek)Podatek.Clone();
            if (Historia != null) r.Historia = (Historia)Historia.Clone();
            if (Rachunek != null) r.Rachunek = (Rachunek)Rachunek.Clone();
            return r;
        }

        
    }
}


//NIEUZYWANE z ORG BAZY
//public virtual int Auto
//public virtual string Kol_MietePL
//public virtual int? Kol_Kilometer
//public virtual int? Kol_ArbeitKm
//public virtual bool Kol_Wohnung
//public virtual int? Kol_KinderGeldPl
//public virtual DateTime? Kol_Do1w
//public virtual decimal Kol_Do2w
//public virtual DateTime? Kol_Do3w
//public virtual DateTime? Kol_Doauto
//public virtual decimal Kol_Firmwagen
//public virtual bool Kol_Buss
//public virtual int Kol_KartaPodatkowa //0 i -1
//public virtual int Kol_KartaZastepcza
//public virtual string Kol_BankMiejsce
//public virtual int? Kol_MietesvPl //1,2,3
//public virtual int Kol_KindGeldPl //30 i 100

//ROZSZYFROWANE
//public virtual int Kol_Lista aktualny status
//public virtual string Kol_Do1m //wyznanie partner
//public virtual DateTime? Kol_MieteD //data slubu
//public virtual string Kol_Doxm //puste
//public virtual string Kol_Zug //mandaten partnera
//public virtual string Kol_MietesvD //wspolmalzonek
//public virtual string Kol_KondGeldD //email
//public virtual string Kol_KmStand //urodzenie dzieci
//public virtual string Kol_Fahrbuch //3 cyfry i 2 litery LISTA ZAPLAT
//public virtual string Kol_Finanzamt //historia daty
//public virtual string Kol_Kmstand2 //historia list
//public virtual string Kol_Fahrscheine //historia operatorzy