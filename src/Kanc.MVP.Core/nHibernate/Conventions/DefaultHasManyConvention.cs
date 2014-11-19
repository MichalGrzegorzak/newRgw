using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Kanc.MVP.Core.nHibernate.Conventions
{
    public class DefaultHasManyConvention : IHasManyConvention
    {
        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Key.Column(string.Format("{0}{1}", "Id", instance.EntityType.Name));
            instance.LazyLoad();
        }
    }
}