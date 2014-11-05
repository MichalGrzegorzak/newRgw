using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Commons
{
    public static class DictionaryExtension
    {
        /// <summary>
        /// If a key exists in a dictionary, return its value, 
        /// otherwise return the default value for that type.
        /// </summary>
        public static U GetOrDefault<T, U>(this Dictionary<T, U> dict, T key)
        {
            return dict.GetOrDefault(key, default(U));
        }

        /// <summary>
        /// If a key exists in a dictionary, return its value,
        /// otherwise return the provided default value.
        /// </summary>
        public static U GetOrDefault<T, U>(this Dictionary<T, U> dict, T key, U defaultValue)
        {
            return dict.ContainsKey(key)
                ? dict[key]
                : defaultValue;
        }

        public static void AddSafe<T, U>(this Dictionary<T, U> dict, T key, U value)
        {
            if (!dict.ContainsKey(key))
                dict.Add(key, value);
            else
                dict[key] = value;
        }
    }
}
