using System.Linq;
using System.ComponentModel;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using NHibernate.Validator.Engine;

namespace Kanc.UI.Tests
{
    public interface IGenericEntity<TIdentity> : IEquatable<IGenericEntity<TIdentity>>
    {
        TIdentity Id { get; }
    }

    [Serializable]
    public abstract class AbstractEntity<TIdentity> : IGenericEntity<TIdentity>
    {
        private int? requestedHashCode;

        #region IGenericEntity<TIdentity> Members

        public abstract TIdentity Id { get; protected set; }

        /// <summary>
        /// Compare equality trough Id
        /// </summary>
        /// <param name="other">Entity to compare.</param>
        /// <returns>true is are equals</returns>
        /// <remarks>
        /// Two entities are equals if they are of the same hierarcy tree/sub-tree
        /// and has same id.
        /// </remarks>
        public virtual bool Equals(IGenericEntity<TIdentity> other)
        {
            if (null == other || !GetType().IsInstanceOfType(other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            bool otherIsTransient = Equals(other.Id, default(TIdentity));
            bool thisIsTransient = IsTransient();
            if (otherIsTransient && thisIsTransient)
            {
                return ReferenceEquals(other, this);
            }

            return other.Id.Equals(Id);
        }

        #endregion

        protected bool IsTransient()
        {
            return Equals(Id, default(TIdentity));
        }

        public override bool Equals(object obj)
        {
            var that = obj as IGenericEntity<TIdentity>;
            return Equals(that);
        }

        public override int GetHashCode()
        {
            if (!requestedHashCode.HasValue)
            {
                requestedHashCode = IsTransient() ? base.GetHashCode() : Id.GetHashCode();
            }
            return requestedHashCode.Value;
        }
    }

    [Serializable]
    public class Entity : AbstractEntity<int>
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;

        public override int Id { get; protected set; }

        public virtual bool IsNew()
        {
            return IsTransient();
        }

        public virtual bool IsValid()
        {
            return Context.Validator.IsValid(this);
        }

        public virtual bool IsTracking { get; set; }
        public virtual bool IsModified { get; set; }
        
        public virtual string TypeName { get; set; }

        //protected bool _isModified = false;
        //public virtual bool IsModified { get { return _isModified; } }

        public virtual InvalidValue[] GetErrors()
        {
            ValidatorEngine val = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();
            return val.Validate(this);
        }
    }

    [Serializable]
    public class EntityBindable : Entity, INotifyPropertyChanged, IDataErrorInfo
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
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
            if (value != null && EqualityComparer<T>.Default.Equals(field, value)) 
                return false;

            field = value;
            OnPropertyChanged(selectorExpression);

            if (IsTracking)
                IsModified = true;

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