 using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
 using System.Linq.Expressions;
 using System.Text;
using System.ComponentModel;
 using NHibernate.Validator.Constraints;
 using NHibernate.Validator.Engine;

namespace Kanc.UI.Tests
{
    
    [Serializable]
    public class Rachunek : EntityBindable
    {
        public virtual string Name { get; set; }
        public virtual Klient Klient { get; set; }

        public Rachunek()
        {
            Klient = new Klient();
        }

        protected virtual List<NHibernate.Validator.Engine.InvalidValue> GetErrors()
        {
            List<NHibernate.Validator.Engine.InvalidValue> results = new List<InvalidValue>();

            ValidatorEngine val = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();
            InvalidValue[] errors = val.Validate(this.Klient);
            results.AddRange(errors);

            return results;
        }

    }
}