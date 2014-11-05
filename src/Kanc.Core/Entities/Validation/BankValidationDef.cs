using System;
using Kanc.Core.Entities;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Constraints;
using NHibernate.Validator.Engine;

namespace Kanc.Core.Entities.Validation
{
    public class BankValidationDef : ValidationDef<Bank>
    {
        public BankValidationDef()
        {
            Define(a => a.Adres).NotNullableAndNotEmpty();
            Define(a => a.Blz).IsNumeric();
            Define(a => a.Nazwa).NotNullableAndNotEmpty();
            Define(a => a.Swift).IfNotEmptyMinLength(3);
        }
    }
}