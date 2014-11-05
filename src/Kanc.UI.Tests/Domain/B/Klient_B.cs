 using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
 using System.Linq.Expressions;
 using System.Text;
using System.ComponentModel;
 using NHibernate.Validator.Constraints;
 using NHibernate.Validator.Engine;

namespace Kanc.UI.Tests
{
    
    [Serializable]
    public class Klient_B : Entity//, INotifyPropertyChanged
    {
        [NotEmpty]
        public virtual string Name { get; set; }
        [Past]
        public virtual DateTime? Urodz { get; set; }

        public virtual Rachunek_B Rachunek { get; set; }

        public Klient_B()
        {
        }

        public Klient_B(Rachunek_B r)
        {
            Rachunek = r;
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