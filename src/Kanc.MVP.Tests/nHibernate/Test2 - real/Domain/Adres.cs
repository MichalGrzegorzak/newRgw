using System;
using Kanc.MVP.Tests.nHibernate.Domain.Enums;

namespace Kanc.MVP.Tests.nHibernate.Domain
{
    [Serializable]
    public class Adres : ModelBase, IAutoMap
    {
        public virtual string Miasto { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Kod { get; set; }
        public virtual string Miejsce { get; set; }
        //public virtual Kraje Kraj { get; set; }

        //public string PelnyAdres()
        //{
        //    string result = Ulica + ", " + Kod + " " + Miasto;
        //    return result;
        //}

        //public string Linia1()
        //{
        //    return Ulica;
        //}

        //public string Linia2()
        //{
        //    return Kod + " " + Miasto;
        //}

        //public string KodIMiasto()
        //{
        //    return Kod + " " + Miasto;
        //}

        //public override object Clone()
        //{
        //    var result = (Adres)MemberwiseClone();
        //    result.Id = 0;
        //    return result;
        //}

    }
}