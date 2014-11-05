using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Commons;

namespace Kanc.Core.Features.Raporty.DE
{
    public class Estk : BaseEstk1a_2006
    {
        //public Func<string> ResolveFileName = () => { "07_Estk1a_" + this.Rok + ".pdf"; };
        
        public Estk()
        {
            FileName = "07_Estk1a_{0}" + ".pdf";
            CountryFolderCode = "DE";
        }

        public override string ResolveReportPath()
        {
            FileName = FileName.Frmt(Rok);
            string path = base.ResolveReportPath();
            return path;
        }

        public override void MapFieldsWithRozliczenie(Entities.Rozliczenie rozlicz)
        {
            base.MapFieldsWithRozliczenie(rozlicz);
            //Fields.Add("Nazwisko", rozlicz.Klient.Nazwisko);
        }
    }
}
