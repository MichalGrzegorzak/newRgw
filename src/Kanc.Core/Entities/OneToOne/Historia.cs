using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Kanc.Commons;

namespace Kanc.Core.Entities
{
    [Serializable]
    public class Historia : OneToOneEntity
    {
        public Historia() { }
        public Historia(Rozliczenie roz) { this.Rozliczenie = roz; }
        //HISTORIA
        //finanzamt + kmstandt2 + fahrsheine = data + lista + kto

        //KmStand2
        public virtual string Statusy { get; set; }
        //Finanzamt
        public virtual string Daty { get; set; }
        //Fahrscheine
        public virtual string Operatorzy { get; set; }
        // najprawdopodobniej I-sza data z listy
        public virtual DateTime? DataPrzyjecia { get; set; }
        // najprawdopodobniej ostatnia data z listy (??) lub po kodzie
        public virtual DateTime? DataPrzeniesienia { get; set; }

        public virtual List<int> ParseStatusy(string statusy)
        {
            statusy = statusy.Trim('.', ';');
            if (statusy.IsExistAny('`', '\'', ':', ','))
                statusy = statusy.ReplaceAllOf(';', '`', '\'', ':', ',');

            List<int> results = new List<int>();
            foreach (string s in statusy.Split(';'))
            {
                int dt = s.ParseSafe<int>();
                results.Add(dt);
            }
            return results;
        }
        public virtual List<DateTime> ParseDaty(string daty)
        {
            daty = daty.Trim('.', ';');

            List<DateTime> results = new List<DateTime>();
            foreach (string s in daty.Split(';'))
            {
                DateTime dt = s.ParseSafe<DateTime>();
                if (dt == DateTime.MinValue)
                    dt = (DateTime)SqlDateTime.MinValue;
                results.Add(dt);
            }
            return results;
        }
        public virtual List<string> ParseOperatorzy(string operatorzy)
        {
            List<string> results = (from s in operatorzy.Split(';')
                                    where s.IsNotNullOrEmptyT()
                                    select s.Parse<string>()).ToList();
            return results;
        }

        
    }
}