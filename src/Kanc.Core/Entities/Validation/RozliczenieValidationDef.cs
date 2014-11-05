using System;
using Kanc.Core.Entities;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Engine;

namespace Kanc.Core.Entities.Validation
{
    public class RozliczenieValidationDef : ValidationDef<Rozliczenie>
    {
        public RozliczenieValidationDef()
        {
            Define(a => a.Rok).GreaterThanOrEqualTo(1900).WithMessage("Rok musi być większy niż 1900.");

            Define(a => a.Klient).IsValid();
            Define(a => a.Partner).IsValid();
            //Define(a => a.AdresRozliczenia).IsValid();
            Define(a => a.Podatek).IsValid();
            Define(a => a.Konto).IsValid();
            Define(a => a.Rachunek).IsValid();
            Define(a => a.Historia).IsValid();
            
            //Define(a => a.Status).
            //Define(a => a.Tracks).HasValidElements();
        }
    }
}