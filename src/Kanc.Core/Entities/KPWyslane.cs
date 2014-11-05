using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Kanc.Core.Entities
{
    /// <summary>
    /// tblKplWyslane
    /// </summary>
    [Serializable]
    public class KPWyslane : EntityAdv
    {
        public KPWyslane() { }

        public virtual int Rok { get; set; }
        //- to jest zjebane wiekszosc 100
        public virtual int NrListy { get; set; }
        //nie wiadomno po co
        public virtual int Pozycja { get; set; }
        public virtual Rozliczenie Rozliczenie { get; set; }

        public override object Clone()
        {
            var result = (KPWyslane)MemberwiseClone();
            result.Id = 0;
            if (Rozliczenie != null) 
                result.Rozliczenie = (Rozliczenie)Rozliczenie.Clone();
            return result;
        }
    }
}