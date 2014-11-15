using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Kanc.MVP.Core.Domain.Rozliczenie;

namespace Kanc.MVP.Core.nHibernate.DomainMappings
{
    public class KlientMappingOverride : IAutoMappingOverride<Klient>
    {
        public void Override(AutoMapping<Klient> mapping)
        {
        
        }
    }
}
