using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Kanc.Commons
{
    public static class PropertyResolver
    {
        public static string GetMemberName<TObject, TProperty>(Expression<Func<TObject, TProperty>> expression)
        {
            var member = expression.Body as MemberExpression;
            if (member != null)
            {
                string name = member.ToString();
                string[] arr = name.Split('.');
                
                if (arr.Length == 2)
                    name = arr[1];
                else
                {
                    name = name.Substring(name.IndexOf('.') + 1);
                }
                return name;
            }

            throw new ArgumentException("expression");
        }
    }
}
