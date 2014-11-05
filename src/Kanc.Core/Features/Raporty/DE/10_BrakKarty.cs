using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Commons;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BrakKarty : BaseBrakkarty
    {
        public BrakKarty()
        {
            FileName = "10_BrakKarty" + ".pdf";
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
