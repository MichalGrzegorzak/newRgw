using System;
using System.ComponentModel;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;

namespace Kanc.UI.Tests
{
    public class Rozliczenie : EntityBindable, IRozliczenie
    {
        public Rozliczenie()
        {
            //Historia = new BindingList<RozliczenieHistoria> { AllowNew = true };    
        }

        public virtual int Rok { get; set; }
        public virtual Kraje Kraj { get; set; }

        private Klient _klient = new Klient();

        public virtual Klient Klient
        {
            get { return _klient; }
            set { SetField(ref _klient, value, () => Klient); }
        }

        public virtual string MandId { get; set; }
        public virtual Int64? Steuernummer { get; set; } //taki niemiecki NIP
        
        //podst
        public virtual string Imie { get; set; }
        public virtual string ImieDe { get; set; }
        public virtual string Nazwisko { get; set; }
        public virtual string NazwiskoDe { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Komorka { get; set; }
        public virtual string Notka { get; set; }
        public virtual string Email { get; set; }
        
        public virtual int? KontoLk { get; set; }
        public virtual int KontoBlz { get; set; }
        public virtual Int64 KontoNr { get; set; }

        //dzieci
        public virtual int DzieciLiczba { get; set; }
        public virtual string DzieciDaty { get; set; }

        //statusy
        public virtual int Status { get; set; }
        public virtual int Pozycja { get; set; }
        public virtual int Zaplacono { get; set; }
        public virtual DateTime CreatedOn { get; set; }  //data przyjecia
        public virtual DateTime MovedOn { get; set; } //data przeniesienia

        public virtual string CreatedBy { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime ModifiedOn { get; set; }
    }
}


//NIEUZYWANE z ORG BAZY
//public virtual int Auto { get; set; }
//public virtual string Kol_MietePL { get; set; }
//public virtual int? Kol_Kilometer { get; set; }
//public virtual int? Kol_ArbeitKm { get; set; }
//public virtual bool Kol_Wohnung { get; set; }
//public virtual int? Kol_KinderGeldPl { get; set; }
//public virtual DateTime? Kol_Do1w { get; set; }
//public virtual decimal Kol_Do2w { get; set; }
//public virtual DateTime? Kol_Do3w { get; set; }
//public virtual DateTime? Kol_Doauto { get; set; }
//public virtual decimal Kol_Firmwagen { get; set; }
//public virtual bool Kol_Buss { get; set; }
//public virtual int Kol_KartaPodatkowa { get; set; } //0 i -1
//public virtual int Kol_KartaZastepcza { get; set; }
//public virtual string Kol_BankMiejsce { get; set; }
//public virtual int? Kol_MietesvPl { get; set; } //1,2,3
//public virtual int Kol_KindGeldPl { get; set; } //30 i 100

//ROZSZYFROWANE
//public virtual int Kol_Lista { get; set; } aktualny status
//public virtual string Kol_Do1m { get; set; } //wyznanie partner
//public virtual DateTime? Kol_MieteD { get; set; } //data slubu
//public virtual string Kol_Doxm { get; set; } //puste
//public virtual string Kol_Zug { get; set; } //mandaten partnera
//public virtual string Kol_MietesvD { get; set; } //wspolmalzonek
//public virtual string Kol_KondGeldD { get; set; } //email
//public virtual string Kol_KmStand { get; set; } //urodzenie dzieci
//public virtual string Kol_Fahrbuch { get; set; } //3 cyfry i 2 litery LISTA ZAPLAT
//public virtual string Kol_Finanzamt { get; set; } //historia daty
//public virtual string Kol_Kmstand2 { get; set; } //historia list
//public virtual string Kol_Fahrscheine { get; set; } //historia operatorzy