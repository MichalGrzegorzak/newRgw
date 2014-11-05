using System;
using Kanc.Core.Entities;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Constraints;
using NHibernate.Validator.Engine;

namespace Kanc.Core.Entities.Validation
{
    public class KontoValidationDef : ValidationDef<Konto>
    {
        public KontoValidationDef()
        {
            Define(a => a.KontoNr).IsNumeric();
            Define(a => a.KontoLk).IfNotEmptyMinLength(2).And.MaxLength(2).And.IsNumeric();

            Define(a => a.BankAdres).IfNotEmptyMinLength(3).WithMessage("Zbyt krótki adres banku");
            Define(a => a.BankBLZ).IsNumeric();
            Define(a => a.BankNazwa).NotNullableAndNotEmpty();
            Define(a => a.BankSwift).IfNotEmptyMinLength(3);
        }
    }
}