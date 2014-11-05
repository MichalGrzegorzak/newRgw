using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Commons
{
    class QueryHelper
    {
        //public virtual IList<Rozliczenie> GetByMultipleIds(int[] ids)
        //{
        //    var result = Session
        //      .CreateCriteria(typeof(Rozliczenie))
        //      .Add(Restrictions.In("Id", ids))
        //      .List<Rozliczenie>();

        //    result = ids.Join //to order list by passed ids
        //      (result, id => id, r => r.Id, (i, r) => r).ToList();

        //    return result;
        //}
    }
}
