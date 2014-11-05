using System;
using System.ComponentModel;
using Castle.Core.Internal;
using Castle.DynamicProxy;

namespace Kanc.Commons
{
   [Serializable]
    public class NotifyPropertyChangedInterceptor : IInterceptor
    {
        private readonly string typeName;
        private PropertyChangedEventHandler subscribers = delegate { };

        public NotifyPropertyChangedInterceptor(string typeName)
        {
            this.typeName = typeName;
        }

        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.DeclaringType == typeof(DataBindingFactory.IMarkerInterface))
            {
                invocation.ReturnValue = typeName;
                return;
            }
            if (invocation.Method.DeclaringType == typeof(INotifyPropertyChanged))
            {
                var propertyChangedEventHandler = (PropertyChangedEventHandler)invocation.Arguments[0];
                if (invocation.Method.Name.StartsWith("add_"))
                {
                    subscribers += propertyChangedEventHandler;
                }
                else
                {
                    subscribers -= propertyChangedEventHandler;
                }
                return;
            }

            invocation.Proceed();

            if (invocation.Method.Name.StartsWith("set_"))
            {
                var propertyName = invocation.Method.Name.Substring(4);
                subscribers(invocation.InvocationTarget, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
