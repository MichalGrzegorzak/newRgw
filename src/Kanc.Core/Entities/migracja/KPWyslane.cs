using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    /// <summary>
    /// tblKplWyslane
    /// </summary>
    public class KPWyslane : EntityBase
    {
        public override int Id { get; set; }
        public int Rok { get; set; }
        public int RozliczenieId { get; set; }
        
        public int NrListy { get; set; } //- to jest zjebane wiekszosc 100
        public int Pozycja { get; set; } //nie wiadomno po co

        //data przeniesienia - createdOn

        public KPWyslane() : base() { }
        public KPWyslane(tblKplWyslane r) : this()
        {
            Rok = r.Rok.Parse<int>();
            NrListy = r.NrListy.Value;
            Pozycja = r.Pozycja.Value;

            if (r.NrPodatku.HasValue) RozliczenieId = r.NrPodatku.Value;
            if (r.DataPrzenies.HasValue) CreatedOn = r.DataPrzenies.Value;
            if (r.OperatorX.IsNotNullOrEmptyT()) CreatedBy = r.OperatorX;
        }
    }
}
