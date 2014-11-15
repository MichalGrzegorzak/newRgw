using System;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Kanc.MVP.Tests.nHibernate.Core
{
    public class AutomappingConfiguration : DefaultAutomappingConfiguration
    {
        private static readonly IList<string> IgnoredMembers = new List<string>
        {
            "IsNew", "IsDeleted", "ImieINazwisko", "ImieINazwiskoDe"
        };

        public override bool ShouldMap(Type type)
        {
            return type.IsSubclassOf(typeof (ModelBase))
                && type.GetInterfaces().Any(y => y == typeof(IAutoMap));
        }

        public override bool ShouldMap(Member member)
        {
            return base.ShouldMap(member) && !IgnoredMembers.Contains(member.Name); ;
        }
    }

    public class CascadeAllConvention : IHasOneConvention, IHasManyConvention, IReferenceConvention
    {
        public void Apply(IOneToOneInstance instance)
        {
            instance.Cascade.All();
        }

        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Inverse();
            instance.Cascade.All();
        }

        public void Apply(IManyToOneInstance instance)
        {
            instance.Cascade.All();
        }
    }

    public class DefaultStringLengthConvention : IPropertyConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            instance.Length(300);
        }
    }

    public class DefaultReferenceConvention : IReferenceConvention
    {
        public void Apply(IManyToOneInstance instance)
        {
            instance.Column(string.Format(instance.Class.Name.StartsWith("Id") ? "{1}" : "{0}{1}", "Id",
                                          instance.Class.Name));
            instance.LazyLoad();

        }
    }

    public class DefaultHasManyConvention : IHasManyConvention
    {
        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Key.Column(string.Format("{0}{1}", "Id", instance.EntityType.Name));
            instance.LazyLoad();
        }
    }

    public class DefaultTableNameConvention : IClassConvention
    {
        public void Apply(IClassInstance instance)
        {
            instance.Table(string.Format("{0}{1}", "GL_", instance.EntityType.Name));
        }
    }

    public class DefaultPrimaryKeyConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.Column("Id");
            instance.GeneratedBy.Native();
        }
    }

}
