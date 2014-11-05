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
    public class Klient : EntityBindable
    {
        private DateTime? _Urodz;
        private string _Name;
        private Kraj _Kraj;

        public virtual string Name
        {
            get { return _Name; }
            set { SetField(ref _Name, value, () => Name); }
        }
        public virtual DateTime? Urodz
        {
            get { return _Urodz; }
            set { SetField(ref _Urodz, value, () => Urodz); }
        }
        public virtual Kraj Kraj
        {
            get { return _Kraj; }
            set
            {
                if(value == null) value = new Kraj();
                SetField(ref _Kraj, value, () => Kraj);
            }
        }

        public Klient()
        {
            //Kraj = new Kraj();
        }

        protected virtual List<NHibernate.Validator.Engine.InvalidValue> GetErrors()
        {
            List<NHibernate.Validator.Engine.InvalidValue> results = new List<InvalidValue>();
                //base.GetErrors();

            ValidatorEngine val = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();
            InvalidValue[] errors = val.Validate(this.Kraj);
            results.AddRange(errors);

            return results;
        }

    }
}