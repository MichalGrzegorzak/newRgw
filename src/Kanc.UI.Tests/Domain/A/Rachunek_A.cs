 using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
 using System.Linq.Expressions;
 using System.Text;
using System.ComponentModel;
 using Kanc.Commons;
 using NHibernate.Validator.Constraints;
 using NHibernate.Validator.Engine;

namespace Kanc.UI.Tests
{
    
    [Serializable]
    public class Rachunek_A : Entity
    {
        [NotNullNotEmpty]
        public virtual string Name { get; set; }

        [Valid]
        public virtual Klient_A KlientA { get; set; }

        public Rachunek_A()
        {
            KlientA = new Klient_A();
        }

        protected virtual List<NHibernate.Validator.Engine.InvalidValue> GetErrors()
        {
            List<NHibernate.Validator.Engine.InvalidValue> results = new List<InvalidValue>();

            ValidatorEngine val = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();
            InvalidValue[] errors = val.Validate(this.KlientA);
            results.AddRange(errors);

            return results;
        }

    }
}