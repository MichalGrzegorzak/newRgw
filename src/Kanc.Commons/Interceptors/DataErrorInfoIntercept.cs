using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;
using NHibernate.Validator.Engine;

namespace Kanc.Commons
{
    [Serializable]
    public class DataErrorInfoInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.Name == "get_Error")
            {
                ValidatorEngine val = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();
                InvalidValue[] errors = val.Validate(invocation.Proxy);
                invocation.ReturnValue = String.Join(Environment.NewLine, errors.Select(e => e.Message).ToArray());
            }
            else if ((invocation.Method.Name == "get_Item") && (invocation.Arguments.Length == 1) && (invocation.Arguments[0] is String))
            {
                String propertyName = invocation.Arguments[0].ToString();
                ValidatorEngine val = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();

                InvalidValue[] errors = val.Validate(invocation.Proxy);
                invocation.ReturnValue = String.Join(Environment.NewLine, errors.Where(e => e.PropertyName == propertyName).Select(e => e.Message).ToArray());
            }

            if (invocation.InvocationTarget != null)
            {
                invocation.Proceed();
            }
        }

    }
}
