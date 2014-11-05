using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    public class Historia : EntityBase
    {
        public override int Id { get; set; }
        public string Statusy { get; set; } //KmStand2
        public string Daty { get; set; } //Finanzamt
        public string Operatorzy { get; set; } //Fahrscheine

        public DateTime? DataPrzyjecia { get; set; } // najprawdopodobniej I-sza data z listy
        public DateTime? DataPrzeniesienia { get; set; } // najprawdopodobniej ostatnia data z listy (??) lub po kodzie

        public Historia() : base()
        {
            string empty = "<br>";
            Daty = Operatorzy = empty;
            //if (n.Datum.HasValue) CreatedOn = n.Datum.Value;
        }
        public Historia(Niemieckie n) : this()
        {
            List<int> stat = new List<int>();
            List<DateTime> daty = new List<DateTime>();
            List<string> oper = new List<string>();

            if (n.Kmstand2.IsNotNullOrEmptyT())
            {
                stat = ParseStatusy(n.Kmstand2);
                Statusy = stat.ToLine(";");
            }
            if (n.Finanzamt.IsNotNullOrEmptyT())
            {
                daty = ParseDaty(n.Finanzamt);
                Daty = daty.ToLine(";");
                DataPrzyjecia = daty.First();
                DataPrzeniesienia = daty.Last();
            }

            //wyrownaj oba
            while (stat.Count() != daty.Count())
            {
                WyrownajDaty(ref stat, ref daty);
            }

            if (n.Fahrscheine.IsNotNullOrEmptyT())
            {
                oper = ParseOperatorzy(n.Fahrscheine);
                if(daty.Count() != oper.Count())
                {
                    int x = daty.Count() - oper.Count();
                    for (int i = 0; i < x; i++ )
                        oper.Add("anon");
                }
                Operatorzy = oper.ToLine(";");
            }
        }

        private void WyrownajDaty(ref List<int> staty, ref List<DateTime> daty)
        {
            if(staty.Count < daty.Count)
            {
                daty.Remove(daty.First());
            }
            else
            {
                if (staty.IndexOf(0) > -1)
                    staty.Remove(0);
                else
                    staty.Remove(staty.First());
            }
        }

        public List<int> ParseStatusy(string statusy)
        {
            statusy = statusy.Trim('.', ';');
            if (statusy.IsExistAny('`','\'',':',','))
                statusy = statusy.ReplaceAllOf(';','`', '\'', ':',',');

            //List<int> results = (from s in statusy.Split(';')
            //                     where s.IsNotNullOrEmptyT()
            //                     select s.Parse<int>()).ToList();

            List<int> results = new List<int>();
            foreach (string s in statusy.Split(';'))
            {
                int dt = s.ParseSafe<int>();
                results.Add(dt);
            }  
            return results;
        }
        public List<DateTime> ParseDaty(string daty)
        {
            daty = daty.Trim('.', ';');

            List<DateTime> results = new List<DateTime>();
            foreach (string s in daty.Split(';'))
            {
                DateTime dt = s.ParseSafe<DateTime>();
                if (dt == DateTime.MinValue) 
                    dt = (DateTime) SqlDateTime.MinValue;
                results.Add(dt);
            }    
           return results;
        }
        public List<string> ParseOperatorzy(string operatorzy)
        {
            List<string> results = (from s in operatorzy.Split(';')
                                    where s.IsNotNullOrEmptyT()
                                    select s.Parse<string>()).ToList();
            return results;
        }
    }
}
