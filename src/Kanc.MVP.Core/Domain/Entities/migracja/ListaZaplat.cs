using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    /// <summary>
    /// ListaZaplat & NL
    /// </summary>
    public class ListaZaplat : EntityBase
    {
        //createdon = Open

        public ListaZaplat()
        {
            IsClosed = false;
            KodListyZapl = "<br>";
        }
        public ListaZaplat(tblListaZaplat lista) : this()
        {
            CountryId = 1; //obojnetnie jaki kraj 
            if (lista.DataOtwarcia.HasValue) CreatedOn = lista.DataOtwarcia.Value;
            if (lista.Zamknieta.HasValue) IsClosed = lista.Zamknieta.Value;
            if (lista.ListaZaplat.IsNotNullOrEmptyT()) KodListyZapl = lista.ListaZaplat;
            ClosedOn = lista.DataZamknieta;
        }
        public ListaZaplat(tblListaZaplatNL lista) : this()
        {
            CountryId = 4; //holandia
            if (lista.DataOtwarcia.HasValue) CreatedOn = lista.DataOtwarcia.Value;
            if (lista.Zamknieta.HasValue) IsClosed = lista.Zamknieta.Value;
            if (lista.ListaZaplatNL.IsNotNullOrEmptyT()) KodListyZapl = lista.ListaZaplatNL;
            ClosedOn = lista.DataZamknieta;
        }

        public override int Id { get; set; }
        public int CountryId { get; set; }
        public bool IsClosed { get; set; }
        public string KodListyZapl { get; set; } //Farhbuch z Niemieckie
        //public DateTime Open { get; set; }
        public DateTime? ClosedOn { get; set; }
        
    }
}
