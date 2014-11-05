using System;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Constraints;

namespace Kanc.Core.Entities.Validation
{
    public class KlientValidationDef : ValidationDef<Klient>
    {
        //UWAGA TExtboxy zwracaja teraz NULL`a jesli sa puste !!
        public KlientValidationDef()
        {
            //Define(a => a.MandId).IfNotEmptyNumeric(1);
            Define(a => a.Steuernummer).IfNotEmptyMinLength(3);

            Define(a => a.Imie).NotNullableAndNotEmpty();
            Define(a => a.ImieDe).NotNullableAndNotEmpty();
            Define(a => a.Nazwisko).NotNullableAndNotEmpty();
            Define(a => a.NazwiskoDe).NotNullableAndNotEmpty();
            Define(a => a.Komorka).IfNotEmptyMinLength(10);
            Define(a => a.Telefon).IfNotEmptyMinLength(10);
            Define(a => a.Email).IsEmail();
            Define(a => a.Plec).NotNullable();
            Define(a => a.Urodz).Satisfy(x=> x.HasValue && x.Value < DateTime.Now.AddYears(-13))
                .WithMessage("Musisz podać poprawną date urodzenia.");
            Define(a => a.DataSlubu).IsInThePast();

            //Define(a => a.Religia).IsInThePast();
        }
    }
}