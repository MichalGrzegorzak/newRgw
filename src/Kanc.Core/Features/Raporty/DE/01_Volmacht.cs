using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Commons;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class Volmacht : BaseRptpnvollmacht
    {
        public Volmacht()
        {
            FileName = "01_rptpnvollmacht.pdf";
            CountryFolderCode = "DE";
        }

        public override string ResolveReportPath()
        {
            return base.ResolveReportPath();
        }

        public override void MapFieldsWithRozliczenie(Rozliczenie roz)
        {
            base.MapFieldsWithRozliczenie(roz);

            string i = Fields.Nazwisko;
            //Fields.Add();

        }


    }
}
