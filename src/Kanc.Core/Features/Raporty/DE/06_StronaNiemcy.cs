using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Kanc.Commons;

namespace Kanc.Core.Features.Raporty.DE
{
    public class StronaNiemcy : BaseStronaniemcy_both
    {
        public enum Choice
        {
            Both = 0,
            Pl = 1,
            De = 2,
        }

        public Choice Wybor = Choice.Both;

        public StronaNiemcy()
        {
            FileName = "06_StronaNiemcy_{0}" + ".pdf";
            CountryFolderCode = "DE";
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

            //Fields.Add("DataPodpis", rozlicz.CreatedOn.IfValueThenShortDate()); //.dataDateTimePicker.Value.ToShortDateString());
            //Fields.Add("NumerKlienta", rozlicz.idTextBox); //????
            //Fields.Add("Religia", rozlicz.Podatek.Religia);


            // RbZonatyTak = "no";
            // RbZonatyNie = "no";
            //Zonaty = (rozlicz.Partner.Imie.Length > 0);
            //MiejsceZamieszMezaZonyNiemcy = true;
            //MiejscePracyMezaZonyNiemcy = true;
            //ZasilekPl = true;
            //SamochPryw = null; //3 stany
            //OryginalnaKarta = true;
            //LiczbaDzieci = rozlicz.Klient.DzieciLiczba.ToString();
        }

        //public bool? SamochPryw
        //{
        //    set
        //    {
        //        _cxSamochPryw = value;
        //        if (value == null)
        //        {
        //            Fields.AddSafe("cxTransportPublicz", "On");
        //            return;
        //        }
        //        if (value.Value)
        //            Fields.AddSafe("cxSamochPryw", "On");
        //        else
        //            Fields.AddSafe("cxSamochFirmowy", "On");
        //    }
        //}

        public void ResetSamochod() { Pkw = Firmenwagen = Publiczny = false; }

        public bool Pkw
        {
            set { Fields.AddSafe("Pkw", (value) ? "On" : "Off"); }
        }
        public new bool Firmenwagen
        {
            set { Fields.AddSafe("Firmenwagen", (value) ? "On" : "Off"); }
        }
        public new bool Publiczny
        {
            set { Fields.AddSafe("publiczny", (value) ? "On" : "Off"); }
        }
        //public bool Pkw2
        //{
        //    set { Fields.AddSafe("Pkw_2", (value) ? "On" : "Off"); }
        //}
        //public new bool Firmenwagen2
        //{
        //    set { Fields.AddSafe("Firmenwagen_2", (value) ? "yes" : "no"); }
        //}
        //public new bool Publiczny2
        //{
        //    set { Fields.AddSafe("publiczny_2", (value) ? "yes" : "no"); }
        //}
        public bool Zonaty
        {
            set
            {
                Fields.AddSafe("rbZonaty", (value) ? "yes" : "no");
                //Fields.Add("rbZonatyTak", "yes"); //Fields.Add("rbZonatyNie", "no");
            }
        }
        public bool PartnerMieszkaWniemczech
        {
            set
            {
                if(value)
                {
                    Fields.AddSafe("Deutschland", "On");
                    Fields.AddSafe("Polen", "Off");
                }
                else
                {
                    Fields.AddSafe("Deutschland", "Off");
                    Fields.AddSafe("Polen", "On");
                }
            }
        }

        public bool PartnerPracujeNiemcy
        {
            set
            {
                Fields.AddSafe("cxMiejscePracyMezaZonyNiemcy", "Off");
                Fields.AddSafe("cxMiejscePracyMezaZonyPolska", "Off");

                if (value)
                    Fields.AddSafe("cxMiejscePracyMezaZonyNiemcy", "On");
                else
                    Fields.AddSafe("cxMiejscePracyMezaZonyPolska", "On");
            }
        }

        public bool ZasilekPl
        {
            set
            {
                Fields.AddSafe("cxZasilekPl", (value) ? "On" : "Off");
            }
        }
        public bool ZasilekNiemcy
        {
            set
            {
                Fields.AddSafe("cxZasilekNiem", (value) ? "On" : "Off");
            }
        }
        public bool OryginalnaKarta
        {
            set
            {
                Fields.AddSafe("cxOryginalnaKarta", (value) ? "On" : "Off");
            }
        }
        

    }
}
