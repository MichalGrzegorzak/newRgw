using System;

namespace Kanc.MVP.Core.Infrastructure
{
    /// <summary>
    /// Generic event args
    /// Usage:
    /// //public event EventHandler<EventArgs<Bank>> RereadSource;
    //    if(RereadSource != null)
    //       RereadSource.Invoke(this, new EventArgs<Bank>(form.CurrentItem));
    /// </summary>
    public class EventArgs<T> : EventArgs
    {
        public T Data = default(T);

        public EventArgs(T data)
        {
            Data = data;
        }
    }
}
