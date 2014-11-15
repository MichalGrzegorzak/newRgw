using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Kanc.MVP.Core.nHibernate.Conventions
{
    public class DefaultPrimaryKeyConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.Column("Id");
            instance.GeneratedBy.Native();
        }
    }

}
