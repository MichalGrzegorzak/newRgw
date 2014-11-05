using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using NHibernate.Validator.Constraints;

namespace Kanc.UI.Tests
{
    [Serializable]
    public class Kraj : EntityBindable
    {
        //[Min(22)]
        //public virtual int Id { get; set; }

        //[Length(2, 3)]

        private string _Name;
        private string _NazwaEU;
        private string _nazwaPL;

        public Kraj()
        {
            _Name = _NazwaEU = _nazwaPL = "cc";
        }
        
        public virtual string Name
        {
            get { return _Name; }
            set { SetField(ref _Name, value, () => Name); }
        }
        public virtual string NazwaPL
        {
            get { return _nazwaPL; }
            set { SetField(ref _nazwaPL, value, () => NazwaPL); }
        }
        public virtual string NazwaEU
        {
            get { return _NazwaEU; }
            set { SetField(ref _NazwaEU, value, () => NazwaEU); }
        }

    }
}