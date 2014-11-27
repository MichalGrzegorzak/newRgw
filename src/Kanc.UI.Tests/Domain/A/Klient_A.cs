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
    public class Klient_A : Entity
    {
        [NotNullNotEmpty]
        public virtual string Name { get; set; }

        public virtual DateTime? Urodz { get; set; }
        
        //[Valid]
        //public virtual Kraj_A KrajA { get; set; }

        public Klient_A()
        {
            //KrajA = DataBindingFactory.Create<Kraj_A>();
        }

    }
}