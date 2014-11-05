using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using Kanc.Commons;

namespace Kanc.Core
{
    public static class Extension
    {
        public static SortableBindingList<T> ToSortableList<T>(this Table<T> table) where T : class
        {
            return new SortableBindingList<T>(table.ToList());

        }

        //public static SortableBindingList<T> ToSortableList<T>(this Table<T> table) where T : class
        //{
        //    return new SortableBindingList<T>(table.ToList());

        //}

    }
}
