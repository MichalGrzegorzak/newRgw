using System;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Constraints;

namespace Kanc.Core.Entities.Validation
{
    public class PartnerValidationDef : ValidationDef<Partner>
    {
        //UWAGA TExtboxy zwracaja teraz NULL`a jesli sa puste !!
        public PartnerValidationDef()
        {
            Define(a => a.MandId).IfNotEmptyNumeric(1);

            Define(a => a.Imie).NotNullableAndNotEmpty();
            Define(a => a.Nazwisko).IfNotEmptyMinLength(3);
            Define(a => a.Plec).NotNullable();
            Define(a => a.Urodz).Satisfy(x=> x.HasValue && x.Value < DateTime.Now.AddYears(-13))
                .WithMessage("Musisz podać poprawną date urodzenia ( min. 13 lat wstecz).");
            
            //Define(a => a.Religia).IsInThePast();
            
        }
    }
}