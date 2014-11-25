using System;
using System.Runtime.Remoting.Messaging;
using Kanc.MVP.Core.nHibernate.Base;

namespace Kanc.MVP.Core.Domain
{
    [Serializable]
    public class Rozliczenie : EntityBase, IAutoMap
    {
        public Rozliczenie()
        {
            Kraj = Kraje.brak;
            Status = Status.braki; //domyslny
            Rok = DateTime.Now.Year - 1;
            Klient = new Klient(this);
            Partner = new Partner(this);
            Konto = new Konto(this);

            Lookup = new OsobaLookup(new Osoba());

            Created = DateTime.Now;
        }

        public virtual int Rok { get; set; }
        public virtual Kraje Kraj { get; set; }
        public virtual Status Status { get; set; }

        public virtual OsobaLookup Lookup { get; set; }
        public virtual Klient Klient { get; protected set; }
        public virtual Partner Partner { get; protected set; }
        public virtual Konto Konto { get; protected set; }
        //public virtual Adres Adres { get; set; } //do klienta ?

        public virtual int PoprzedniId { get; set; }
        
        //public virtual Podatek Podatek { get; set; }
        //public virtual Rachunek Rachunek { get; set; }
        //public virtual Historia Historia { get; set; }

        public virtual DateTime? Created { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? Modified { get; set; }
        public virtual string ModifiedBy { get; set; }
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