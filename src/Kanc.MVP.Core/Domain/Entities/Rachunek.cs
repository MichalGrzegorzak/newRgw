using System;
using Kanc.MVP.Core.Domain.Entities.Base;
using Kanc.MVP.Core.Domain.Entities.OneToOne;

namespace Kanc.MVP.Core.Domain.Entities
{
    /// <summary>
    /// jedno rozliczenie moze miec wiecej niz 1 rachunek (chociaz jest to malo prawdopodobne)
    /// sprawdzic czy byly takie przypadki na bazie?
    /// </summary>
    [Serializable]
    public class Rachunek : OneToOneEntity
    {
        public Rachunek() { }
        public Rachunek(Rozliczenie roz) : this()
        { this.Rozliczenie = roz; }

        //KP + rok = public string DowodWplaty;

        public virtual int NrKP { get; set; }
        public virtual int Rok { get; set; }
        
       
        
        public virtual string NumerRachunku { get; set; }
        //firmwagen - rechnungbetrag
        public virtual decimal? KwotaRachunek { get; set; }
        //z niemiecie !!! - Auto2
        //Do2W, albo z KPRachunenk - kwotaKP
        public virtual decimal? DoZaplaty { get; set; }

            //Do1W
        public virtual DateTime? Data { get; set; }

        public virtual int PodatekProcent { get; set; }
        
        //niepotrzebne - wyrzucic
        public virtual string KodListyZapl { get; set; }

        public virtual ListaZaplat ListaZaplat { get; set; }

        //public ListaZaplat ListaZaplat1
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //    }
        //}

        public override object Clone()
        {
            var result = (Rachunek)MemberwiseClone();
            result.Id = 0;
            //if (Rozliczenie != null)
            //    result.Rozliczenie = (Rozliczenie)Rozliczenie.Clone();
            //if (ListaZaplat != null)
            //    result.ListaZaplat = (ListaZaplat)ListaZaplat.Clone();
            return result;
        }
        //RACHUNEK
        //fahrbuch - lista zaplat
        //Auto2 - numer rachunku
    }
}