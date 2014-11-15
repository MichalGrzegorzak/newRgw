using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Kanc.MVP.Core.nHibernate.Conventions
{
    public class DefaultTableNameConvention : IClassConvention
    {
        public void Apply(IClassInstance instance)
        {
            instance.Table(string.Format("{0}{1}", "GL_", instance.EntityType.Name));
        }
    }
}