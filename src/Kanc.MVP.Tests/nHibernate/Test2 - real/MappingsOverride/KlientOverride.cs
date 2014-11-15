using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Kanc.MVP.Tests.nHibernate.Domain.Rozliczenie;

namespace Kanc.MVP.Tests.nHibernate.Test2___real.MappingsOverride
{
    public class KlientMappingOverride : IAutoMappingOverride<Klient>
    {
        public void Override(AutoMapping<Klient> mapping)
        {
        
        }
    }
}
