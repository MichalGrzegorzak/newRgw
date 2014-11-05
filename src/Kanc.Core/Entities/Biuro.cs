using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Core.Entities
{
    public class Biuro
    {
        public Biuro()
        {
            Init();
        }

        public void Init()
        {
            BiuroNrKonta = "6600041267";
            BiuroNrBanku = "10050000";
            BiuroName = "WEICHERT, MÖLLER UND  KOLLEGEN GMBH";
            BiuroVorname = "STEUERBERATUNGSGESELSCHAFT";
            BiuroUlicaNr = "FRIEDRICHSTRAßE 58";
            BiuroKodPocztowy = "15537";
            BiuroMiejsce = "ERKNER";
        }

        public string BiuroNrKonta { get; set; }
        public string BiuroNrBanku { get; set; }
        public string BiuroName { get; set; }
        public string BiuroVorname { get; set; }
        public string BiuroUlicaNr { get; set; }
        public string BiuroKodPocztowy { get; set; }
        public string BiuroMiejsce { get; set; }
    }
}
