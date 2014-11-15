using System.Collections.Generic;
using System.Text;

namespace Utils.Extensions
{
    public static class ListExtension
    {
        //public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        //{
        //    foreach (T item in enumeration)
        //    {
        //        action(item);
        //    }
        //}

        public static List<T> CreateList<T>(params T[] values)
        {
            return new List<T>(values);
        }


        public static bool IsEqual(this List<int> internalList, List<int> externalList)
        {
            if (internalList.Count != externalList.Count)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < internalList.Count; i++)
                {
                    if (internalList[i] != externalList[i])
                        return false;
                }
            }

            return true;
        }

        public static string ToStringList(this List<int> items)
        {
            System.Text.StringBuilder sb = new StringBuilder();

            for (int i = 0; i < items.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(",");
                }
                sb.Append(items[i].ToString());
            }

            return sb.ToString();
        }

        public static string ToStringList(this List<string> items)
        {
            System.Text.StringBuilder sb = new StringBuilder();

            for (int i = 0; i < items.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(",");
                }
                sb.Append(items[i].ToString());
            }

            return sb.ToString();
        }

        //public static List<SimpleItem> ToSimpleItemsList<T>(this IEnumerable<T> source, Func<T,SimpleItem> func) where T : class
        //{
        //    List<SimpleItem> simpleList = new List<SimpleItem>();

        //    foreach (T listItem in source)
        //    {
        //        SimpleItem item = func(listItem);
        //        simpleList.Add(item);    
        //    }

        //    return simpleList;
        //}

        
    }
}
