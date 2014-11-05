using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Commons;

namespace Kanc.Core.Features.Raporty.DE
{
    public class PrzebiegAuta : BasePrzebiegauta
    {
        public PrzebiegAuta()
        {
            FileName = "16_PrzebiegAuta" + ".pdf";
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
