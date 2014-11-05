using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using NHibernate.Validator.Constraints;

namespace Kanc.Core.Entities
{
    public class Kraj : EntityBindable
    {
        private string _skrot;
        private string _nazwaPL;
        private string _nazwaEU;

        public virtual string Skrot
        {
            get { return _skrot; }
            set { SetField(ref _skrot, value, () => Skrot); }
        }

        public virtual string NazwaPL
        {
            get { return _nazwaPL; }
            set { SetField(ref _nazwaPL, value, () => NazwaPL); }
        }

        public virtual string NazwaEU
        {
            get { return _nazwaEU; }
            set { SetField(ref _nazwaEU, value, () => NazwaEU); }
        }
    }
}