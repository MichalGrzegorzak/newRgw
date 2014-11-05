using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using NHibernate.Validator.Constraints;

namespace Kanc.UI.Tests
{
    [Serializable]
    public class Kraj_A : Entity
    {
        public Kraj_A()
        {
        }
        [NotNullNotEmpty]
        public virtual string Name { get; set; }
        public virtual string NazwaPL { get; set; }
        public virtual string NazwaEU { get; set; }
    }
}