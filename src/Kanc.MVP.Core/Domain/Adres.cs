using System;
using Kanc.MVP.Core.nHibernate.Base;

namespace Kanc.MVP.Core.Domain
{
    [Serializable]
    public class Adres : ModelBase, IAutoMap
    {
        public virtual void AssignFrom(Adres a)
        {
            Miasto = a.Miasto;
            Ulica = a.Ulica;
            Kod = a.Kod;
            Miejsce = a.Miejsce;
            Kraj = a.Kraj;
        }

        public virtual string Miasto { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Kod { get; set; }
        public virtual string Miejsce { get; set; }
        public virtual Kraje Kraj { get; set; }

        public virtual string PelnyAdres()
        {
            string result = Ulica + ", " + Kod + " " + Miasto;
            return result;
        }

        public virtual string Linia1()
        {
            return Ulica;
        }

        public virtual string Linia2()
        {
            return Kod + " " + Miasto;
        }

        public virtual string KodIMiasto()
        {
            return Kod + " " + Miasto;
        }

        //public override object Clone()
        //{
        //    var result = (Adres)MemberwiseClone();
        //    result.Id = 0;
        //    return result;
        //}

    }
}