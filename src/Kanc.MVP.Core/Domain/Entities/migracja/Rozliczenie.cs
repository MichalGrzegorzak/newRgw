using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    public class Rozliczenie : EntityBase
    {
        public override int Id { get; set; }
        public int PoprzedniId { get; set; }

        public int CustId { get; set; }
        public string MandId { get; set; }
        public int Rok { get; set; }

        public int CountryId { get; set; }
        public int PodatekId { get; set; }
        public int HistoriaId { get; set; }
        public int RachunekId { get; set; }
        public int Status { get; set; } 
        
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        
        public Rozliczenie() : base()
        {
            string empty = "<br>";
            ModifiedBy = empty;
        }
        public Rozliczenie(Niemieckie n) : this()
        {
            PoprzedniId = n.ID;
            MandId = n.MandatenN.ClearText();
            Rok = n.Jahr.ToString().Parse<int>();
            if (n.Lista.HasValue) Status = n.Lista.Value;

            if (n.MandatenN.Contains("W")) CountryId = 4;
            switch (n.Kraj)
            {
                case "Poland": CountryId = 2; break;
                case "Deutschland": CountryId = 3; break;
                case "Holland": CountryId = 4; break;
                //case "Österreich": CountryId = 5; break;
                //case "Czech Republic": CountryId = 6; break;
                //case "Italy": CountryId = 7; break;
                default: CountryId = 1; break; //brak = inny
            }
            if(CountryId == 4 && n.Kraj != "Holland" ) //check 
                CountryId = 4;

            if (n.OperatorX.IsNotNullOrEmpty()) CreatedBy = n.OperatorX.ClearText();
            if (n.Datum.HasValue) CreatedOn = n.Datum.Value;
        }
    }
}
