using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    /// <summary>
    /// [tblKPRachunek]
    /// </summary>
    public class Rachunek : EntityBase
    {
        public override int Id { get; set; }
        public int NrKP { get; set; }
        public int Rok { get; set; }
        //KP + rok = public string DowodWplaty { get; set; }
        public int RozliczenieId { get; set; }

        public decimal? DoZaplaty { get; set; } //Do2W, albo z KPRachunenk - kwotaKP
        public decimal? KwotaRachunek { get; set; } //firmwagen - rechnungbetrag
        public string NumerRachunku { get; set; } //z niemiecie !!! - Auto2
        public DateTime? DataOperacji { get; set; } //Do1W

        public string KodListyZapl { get; set; }
        public int ListaZaplId { get; set; }

        public Rachunek() : base() { }
        public Rachunek(tblKPRachunek r, Niemieckie n) : this()
        {
            string empty = "<br>";
            NumerRachunku = empty;

            if (r.NrKP.HasValue) NrKP = r.NrKP.Value;
            Rok = r.Rok.Parse<int>();

            if (r.ListaZaplat.IsNotNullOrEmptyT()) KodListyZapl = r.ListaZaplat.ClearText();
            //KodListyZapl = r.ListaZaplat.Parse<int>();
            KwotaRachunek = n.Firmwagen;
            if (n.Auto2.IsNotNullOrEmptyT()) NumerRachunku = n.Auto2.ClearText();
            DataOperacji = n.Do1w;

            DoZaplaty = r.KwotaKP;
            if (r.KwotaKP < n.Do2w)
                DoZaplaty = n.Do2w; //do2w jest wazniejsze
        }
    }

    
}
