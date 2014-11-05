using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Validator.Engine;

namespace Kanc.Commons
{
    //NHibernate Validator Type Inspector.
    public class NHVTypeInspector : IEntityTypeInspector
    {
        public Type GuessType(object entityInstance)
        {
            var entity = entityInstance as DataBindingFactory.IMarkerInterface;
            if (entity != null)
            {
                Type typ = Type.GetType(entity.TypeName);
                return typ;
            }
            return null;
        }
    }
}
