using System;
using System.ComponentModel;
//using Castle.Core.Interceptor;
using Castle.DynamicProxy;

namespace Kanc.Commons
{
	public static class DataBindingFactory
	{
		private static readonly ProxyGenerator ProxyGenerator = new ProxyGenerator();

		public static T Create<T>()
		{
			return (T) Create(typeof (T));
		}

		public static object Create(Type type)
		{
			return ProxyGenerator.CreateClassProxy(type, new[]
			{
				typeof (INotifyPropertyChanged),
				typeof (IMarkerInterface),
				typeof (IDataErrorInfo)
			}, 
			new NotifyPropertyChangedInterceptor(type.FullName)
			, new DataErrorInfoInterceptor() 
			);
		}

		public interface IMarkerInterface
		{
			string TypeName { get; }
		}

		
	}
}