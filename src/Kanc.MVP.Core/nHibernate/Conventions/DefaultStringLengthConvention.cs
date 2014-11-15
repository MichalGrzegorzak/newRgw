using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Kanc.MVP.Core.nHibernate.Conventions
{
    public class DefaultStringLengthConvention : IPropertyConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            instance.Length(300);
        }
    }
}