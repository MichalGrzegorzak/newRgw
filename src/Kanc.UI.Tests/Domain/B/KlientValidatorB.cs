using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Validator.Cfg.Loquacious;

namespace Kanc.UI.Tests.Enitites
{
    public class KlientValidatorB : ValidationDef<Klient_B>
    {
        public KlientValidatorB()
        {
            //Define(x => x.KrajA).IsValid();
            Define(x => x.Name).NotNullableAndNotEmpty();
            //Define(x => x.Id).GreaterThanOrEqualTo(13);
        }
    }

    //public class KrajValidationDef : ValidationDef<Kraj_A>
    //{
    //    public KrajValidationDef()
    //    {
    //        Define(x => x.Id).GreaterThanOrEqualTo(15);
    //        Define(x => x.NazwaEU).NotNullableAndNotEmpty();
    //        Define(x => x.).NotNullableAndNotEmpty();
    //        Define(x => x.Name).MinLength(2);
    //    }
    //}

 

}
