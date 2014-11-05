 using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
 using System.Linq.Expressions;
 using System.Text;
using System.ComponentModel;
 using Kanc.Commons;
 using NHibernate.Validator.Constraints;
 using NHibernate.Validator.Engine;

namespace Kanc.UI.Tests
{
    
    [Serializable]
    public class Rachunek_B : Entity //,  INotifyPropertyChanged
    {

        [NotNullNotEmpty]
        public virtual string Name { get; set; }
        [Valid]
        public virtual Klient_B Klient { get; set; }

        public Rachunek_B()
        {
            Klient = new Klient_B(this);
        }

        //string IDataErrorInfo.this[string columnName]
        //{
        //    get
        //    {
        //        return string.Concat(
        //            Context.Validator
        //            .ValidatePropertyValue(this, columnName)
        //            .Select(iv => iv.Message + "\n").ToArray()).Trim();
        //    }
        //}

        //string IDataErrorInfo.Error
        //{
        //    get
        //    {
        //        return string.Concat(
        //            Context.Validator
        //            .Validate(this)
        //            .Select(iv => iv.Message + "\n").ToArray()).Trim();
        //    }
        //}

    }
}