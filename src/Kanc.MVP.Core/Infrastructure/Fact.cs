using System;
using System.ComponentModel;

namespace Kanc.MVP.Core.Infrastructure
{
    public class Fact : INotifyPropertyChanged
	{
		private readonly Func<bool> predicate;

		public Fact(INotifyPropertyChanged observable, Func<bool> predicate)
		{
			this.predicate = predicate;
            observable.PropertyChanged += (sender, args) =>
                {
                    //if (observable is Observable<int>)
                    //{
                    //    var observe = observable as Observable<int>;
                    //    Trace.WriteLine("PropertyChanged called: " + observe.Value);
                    //}
                    //else
                    //{
                    //    Trace.WriteLine("PropertyChanged called: " + observable.ToString());
                    //}
                    PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                };
		}

		public bool Value
		{
			get
			{
				return predicate();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged = delegate { };
	}
}