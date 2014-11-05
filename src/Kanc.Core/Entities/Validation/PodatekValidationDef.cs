using NHibernate.Validator.Cfg.Loquacious;

namespace Kanc.Core.Entities.Validation
{
    public class PodatekValidationDef : ValidationDef<Podatek>
    {
        public PodatekValidationDef()
        {
            //Define(a => a.Religia).GreaterThanOrEqualTo(1);

        }
    }
}