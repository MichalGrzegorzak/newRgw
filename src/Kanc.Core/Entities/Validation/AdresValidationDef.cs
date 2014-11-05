using System;
using Kanc.Core.Entities;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Constraints;
using NHibernate.Validator.Engine;

namespace Kanc.Core.Entities.Validation
{
    public class AdresValidationDef : ValidationDef<Adres>
    {
        public AdresValidationDef()
        {
            //id
            Define(a => a.Kod).NotNullableAndNotEmpty();
            Define(a => a.Miasto).NotNullableAndNotEmpty();
            Define(a => a.Miejsce).IfNotEmptyMinLength(3);
            Define(a => a.Ulica).NotNullableAndNotEmpty();
            //Define(a => a.).NotNullableAndNotEmpty();
        }
    }
}