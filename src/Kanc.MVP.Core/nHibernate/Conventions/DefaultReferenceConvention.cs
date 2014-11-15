using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using FluentNHibernate.Mapping;

namespace Kanc.MVP.Core.nHibernate.Conventions
{
    public class DefaultReferenceConvention : IReferenceConvention
    {
        public void Apply(IManyToOneInstance instance)
        {
            instance.Column(string.Format(instance.Class.Name.StartsWith("Id") ? "{1}" : "{0}{1}", "Id",
                instance.Class.Name));
            //instance.LazyLoad();
            instance.LazyLoad(Laziness.NoProxy);
        }
    }
}