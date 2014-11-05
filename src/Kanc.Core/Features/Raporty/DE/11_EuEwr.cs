using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Commons;

namespace Kanc.Core.Features.Raporty.DE
{
    /// <summary>
    /// specyficzny raport bo pola zaciaga z formularzy - klient moze zmieniac sie miejscami z klientem
    /// dodatkowo mozna podac dodwolne dane klienta - partnera
    /// podobnie 11 & 12 & 13
    /// </summary>
    public class EuEwr : BaseEuewr_both
    {
        public enum Choice
        {
            Both = 0,
            Pl = 1,
            De = 2,
        }

        public Choice Wybor = Choice.Both;
        
        public EuEwr()
        {
            FileName = "11_EuEwr_{0}" + ".pdf";
            CountryFolderCode = "DE";
            Wybor = Choice.Both;
        }

        public override string ResolveReportPath()
        {
            switch (Language)
            {
                case RptLang.Polski: Wybor = Choice.Pl; break;
                case RptLang.Obcy: Wybor = Choice.De; break;
            }
            
            FileName = FileName.Frmt(Wybor.ToString());
            string path = base.ResolveReportPath();
            return path;
        }

        public override void MapFieldsWithRozliczenie(Entities.Rozliczenie rozlicz)
        {
            base.MapFieldsWithRozliczenie(rozlicz);

            if (rozlicz.Rok < 2010)
            {
                Rok = rozlicz.Rok.ToString().Last().ToString();
            }
            else
            {
                Rok = rozlicz.Rok.ToString().Substring(2);
            }
            //Fields.Add("krajzam", rozlicz.Kraj.GetDescription());
            //Fields.Add("miejscezam", rozlicz.Adres.Miejsce);


            //Fields.Add("poprawiony", rozlicz.Popraw);
            //Fields.Add("urzadSkarbowy", rozlicz.urzadSkarbowy);
            //Fields.Add("obywatelstwo", rozlicz.obywatelstwo);

            //Fields.Add("obywatelstwoPartner", rozlicz.partnerobywatelstwo);
            //Fields.Add("krajzamPartner", rozlicz.partnerKrajZamieszkania);
            //Fields.Add("kodpocztowyPartner", rozlicz.partnerKod);
            //Fields.Add("miejscezamPartner", rozlicz.partnerMiesjce);
            //Fields.Add("ulicaPartner", rozlicz.partnerUlica);

            //inne pola
            //Fields.Add("dataZonatyOd", rozlicz.zonatyDateTimePicker.Date.IfValueThenShortDate());
            //Fields.Add("dataWdowiecOd", rozlicz.wdowiecDateTimePicker.Date.IfValueThenShortDate());
        }


    }
}
