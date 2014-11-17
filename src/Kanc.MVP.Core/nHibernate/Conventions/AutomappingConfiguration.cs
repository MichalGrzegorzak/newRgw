using System;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using Kanc.MVP.Core.nHibernate.Base;

namespace Kanc.MVP.Core.nHibernate.Conventions
{
    public class AutomappingConfiguration : DefaultAutomappingConfiguration
    {
        private static readonly IList<string> IgnoredMembers = new List<string>
        {
            "IsDeleted", "AssignFrom", "ImieINazwisko", "ImieINazwiskoDe"
        };

        public override bool ShouldMap(Type type)
        {
            return type.IsSubclassOf(typeof (EntityBase))
                   && type.GetInterfaces().Any(y => y == typeof(IAutoMap));
        }

        public override bool ShouldMap(Member member)
        {
            return base.ShouldMap(member) && !IgnoredMembers.Contains(member.Name); ;
        }
    }
}