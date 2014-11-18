using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Kanc.MVP.Core.Domain;

namespace Kanc.MVP.Core.nHibernate.DomainMappings
{
    public class KlientMappingOverride : IAutoMappingOverride<Klient>
    {
        public void Override(AutoMapping<Klient> mapping)
        {
            //1 to 1 mapping example
            //   map => map.HasOne(x => x.Person)
            //.PropertyRef(x => x.FileData)
            //.Constrained();
        }
    }
}
