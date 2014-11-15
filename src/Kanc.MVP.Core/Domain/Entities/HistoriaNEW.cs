using System;
using Kanc.MVP.Core.Domain.Entities.Base;

namespace Kanc.MVP.Core.Domain.Entities
{
    /// <summary>
    /// Podpiac jako liste zmian historycznych
    /// </summary>
    [Serializable]
    public class HistoriaNEW : EntityAdv
    {
        public HistoriaNEW() { }
        //public HistoriaNEW(Rozliczenie roz) { this.Rozliczenie = roz; }
        //HISTORIA
        //finanzamt + kmstandt2 + fahrsheine = data + lista + kto

        //KmStand2
        public virtual string Status { get; set; }
        //Finanzamt
        public virtual DateTime Data { get; set; }
        //Fahrscheine
        public virtual string Operator { get; set; }
        //// najprawdopodobniej I-sza data z listy
        //public virtual DateTime? DataPrzyjecia { get; set; }
        //// najprawdopodobniej ostatnia data z listy (??) lub po kodzie
        //public virtual DateTime? DataPrzeniesienia { get; set; }

        //public virtual List<int> ParseStatusy(string statusy)
        //{
        //    statusy = statusy.Trim('.', ';');
        //    if (statusy.IsExistAny('`', '\'', ':', ','))
        //        statusy = statusy.ReplaceAllOf(';', '`', '\'', ':', ',');

        //    List<int> results = new List<int>();
        //    foreach (string s in statusy.Split(';'))
        //    {
        //        int dt = s.ParseSafe<int>();
        //        results.Add(dt);
        //    }
        //    return results;
        //}
        //public virtual List<DateTime> ParseDaty(string daty)
        //{
        //    daty = daty.Trim('.', ';');

        //    List<DateTime> results = new List<DateTime>();
        //    foreach (string s in daty.Split(';'))
        //    {
        //        DateTime dt = s.ParseSafe<DateTime>();
        //        if (dt == DateTime.MinValue)
        //            dt = (DateTime)SqlDateTime.MinValue;
        //        results.Add(dt);
        //    }
        //    return results;
        //}
        //public virtual List<string> ParseOperatorzy(string operatorzy)
        //{
        //    List<string> results = (from s in operatorzy.Split(';')
        //                            where s.IsNotNullOrEmptyT()
        //                            select s.Parse<string>()).ToList();
        //    return results;
        //}

        
    }
}