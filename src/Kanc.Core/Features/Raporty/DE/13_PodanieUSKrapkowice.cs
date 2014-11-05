using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Core.Features.Raporty.DE
{
    /// <summary>
    /// specyficzny raport bo pola zaciaga z formularzy - klient moze zmieniac sie miejscami z klientem
    /// dodatkowo mozna podac dodwolne dane klienta - partnera
    /// podobnie 11 & 12 & 13
    /// </summary>
    public class PodanieUSKrapkowice : BasePodanieUSKrapkowice
    {
        public PodanieUSKrapkowice()
        {
            FileName = "13_PodanieUSKrapkowice" + ".pdf";
            CountryFolderCode = "DE";
        }

        public override string ResolveReportPath()
        {
            return base.ResolveReportPath();
        }

        public override void MapFieldsWithRozliczenie(Entities.Rozliczenie rozlicz)
        {
            base.MapFieldsWithRozliczenie(rozlicz);
            //Fields.Add("Nazwisko", rozlicz.Klient.Nazwisko);
        }
    }
}
