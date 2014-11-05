using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Kanc.Commons;
using NHibernate.Validator.Constraints;

namespace Kanc.Core.Entities
{
    [Serializable]
    public class Bank : EntityAdv
    {
        public Bank() { }
        //[NHibernate.Validator.Constraints.Min(1000)] 
        //[Pattern(Regex = "^....-....$", Message = "Musi odpowiadać wzorowi ....-....")]

        public virtual string Blz { get; set; }
        public virtual string Nazwa { get; set; }
        public virtual string Adres { get; set; }
        public virtual string Swift { get; set; }
        public virtual Kraje Kraj { get; set; }

        public override object Clone()
        {
            var result = (Bank)MemberwiseClone();
            result.Id = 0;
            return result;
        }

    }
}