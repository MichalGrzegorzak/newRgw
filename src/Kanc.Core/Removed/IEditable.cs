using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Kanc.Core.Infrastructure
{
    /// <summary>
    /// Przyklad jak dodac do obiektu IEditable
    /// </summary>
    public class IEditable
    {
        private HybridDictionary oldState;

        public virtual void BeginEdit()
        {
            oldState = new HybridDictionary();
            foreach (PropertyInfo property in this.GetType().GetProperties())
            {
                if (property.CanWrite) 
                {
                    oldState[property.Name] = property.GetValue(this, null);
                }
            }
        }

        public virtual void EndEdit()
        {
            oldState = null;
        }

        public virtual void CancelEdit()
        {
            foreach (PropertyInfo property in this.GetType().GetProperties())
            {
                if (property.CanWrite)
                {
                    property.SetValue(this, oldState[property.Name], null);
                }
            }
            oldState = null;
        }
    }
}
