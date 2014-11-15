using System.Linq;
using System.ComponentModel;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using Kanc.Core.Entities;
using Kanc.Core.Model;

namespace Kanc.Core.Entities
{
	public class ItemArgs : EventArgs
	{
		public object Value { get; set; }
		public string PropName { get; set; }
		public object Item { get; set; }

		public ItemArgs(object item)
		{
			this.Item = item;
		}
	}

	
	[Serializable]
	public abstract class EntityBindableNew : Entity, INotifyPropertyChanged, IDataErrorInfo
	{
		private string _CreatedBy = "anon";
		private DateTime? _CreatedOn = DateTime.Now;

		public virtual string CreatedBy
		{
			get { return _CreatedBy; }
			set { OnPropertyChanged(() => CreatedBy); }
		}
		public virtual DateTime? CreatedOn
		{
			get { return _CreatedOn; }
			set { OnPropertyChanged(() => CreatedOn); }
		}

		protected virtual void OnPropertyChanged(Expression<Func<object>> property)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(BindingHelper.Name(property)));
			}
		}

		public virtual event PropertyChangedEventHandler PropertyChanged;

		#region Implementation of IDataErrorInfo

		string IDataErrorInfo.this[string columnName]
		{
			get
			{
				return string.Concat(
					Context.Validator
					.ValidatePropertyValue(this, columnName)
					.Select(iv => iv.Message + "\n").ToArray()).Trim();
			}
		}

		string IDataErrorInfo.Error
		{
			get
			{
				return string.Concat(
					Context.Validator
					.Validate(this)
					.Select(iv => iv.Message + "\n").ToArray()).Trim();
			}
		}

		#endregion
}
	[Serializable]
	public abstract class EntityBindable : Entity, INotifyPropertyChanged, IDataErrorInfo
	{
		private string _CreatedBy = "anon";
		private DateTime? _CreatedOn = DateTime.Now;

		public virtual string CreatedBy
		{
			get { return _CreatedBy; }
			set { SetField(ref _CreatedBy, value, () => CreatedBy); }
		}
		public virtual DateTime? CreatedOn
		{
			get { return _CreatedOn; }
			set { SetField(ref _CreatedOn, value, () => CreatedOn); }
		}

		public virtual event EventHandler<ItemArgs> CreateNew;
		public virtual event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
		protected virtual void OnCreateNew(object item)
		{
			EventHandler<ItemArgs> handler = CreateNew;
			if (handler != null) handler(this, new ItemArgs(item));
		}

		protected virtual void OnPropertyChanged<T>(Expression<Func<T>> selectorExpression)
		{
			if (selectorExpression == null)
				throw new ArgumentNullException("selectorExpression");
			MemberExpression body = selectorExpression.Body as MemberExpression;
			if (body == null)
				throw new ArgumentException("The body must be a member expression");
			OnPropertyChanged(body.Member.Name);
		}

		protected virtual bool SetField<T>(ref T field, T value, Expression<Func<T>> selectorExpression)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) 
				return false;

			field = value;
			OnPropertyChanged(selectorExpression);

			if (IsTracking)
			{
				IsModified = true;
				if (Id == 1)
					OnCreateNew(this);
			}

			return true;
		}

		#region Implementation of IDataErrorInfo

		string IDataErrorInfo.this[string columnName]
		{
			get
			{
				return string.Concat(
					Context.Validator
					.ValidatePropertyValue(this, columnName)
					.Select(iv => iv.Message + "\n").ToArray()).Trim();
			}
		}
		
		string IDataErrorInfo.Error
		{
			get
			{
				return string.Concat(
					Context.Validator
					.Validate(this)
					.Select(iv => iv.Message + "\n").ToArray()).Trim();
			}
		}

		#endregion
	}
}