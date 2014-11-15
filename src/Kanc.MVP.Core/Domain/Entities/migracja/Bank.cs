using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    public class Bank : EntityBase
    {
        private ILog log = LogManager.GetLogger("Bank");

        public override int Id { get; set; }
        public double? BLZ { get; set; } //nr rozliczeniowy
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public string Swift { get; set; }
        public int CountryId { get; set; }
        //public string Skrot { get; set; }

        public static List<int> NieprawidloweBLZ = new List<int>();
        
        public Bank() : base()
        {
            string empty = "<br>";
            BLZ = null;
            Nazwa = Adres = Swift = empty;
            CountryId = 1;
        }

        public Bank(Niemieckie n) : this()
        {
            if (n.BLZ.IsNotNullOrEmpty())
            {
                double result;
                if(double.TryParse(n.BLZ, out result))
                    BLZ = result;
                else
                {
                    Adres = "<swift>";
                    Swift = n.BLZ;
                    NieprawidloweBLZ.Add(n.ID);
                }
            }
            if (n.Bank.IsNotNullOrEmpty())
            {
                Nazwa = n.Bank.ClearText();

                if (Nazwa.ContainsOneOf("Postbank", "Berlin", "Deutsche", "Volksbank", "Dresdner", "Sparkasse", "Volksbank"))
                    CountryId = 3; //niemcy
                else if (Nazwa.ContainsOneOf("PKO", "ING", "WBK"))
                    CountryId = 2;
            }

            //this = SetCountryOfBank(this, n.BankAdres);
            if (n.BankAdres.IsNotNullOrEmptyT())
            {
                Adres = n.BankAdres.ClearText();

                if (Adres.Contains("PLP")) //to musi byc polski bank
                {
                    CountryId = 2;
                    Swift = Adres;
                    Adres = "<swift>";
                }
            }
        }

        //private static Bank SetCountryOfBank(Bank b, string adresBanku)
        //{
        //    return b;
        //}
    }
}
