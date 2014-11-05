using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Kanc.Core.Entities
{
    [Serializable]
    public partial class Polecil : EntityBindable
    {
        public Polecil()
		{
            //PolecilKlientow = new BindingList<Klient> { AllowNew = true };
		}

        public Polecil(Polecil p)
        {
            this.Id = p.Id;
            this._nazwa = p.Nazwa;
            //this.PolecilKlientow = new BindingList<Klient>(p.PolecilKlientow);
        }

       //public virtual IList<Klient> PolecilKlientow { get; set; }

        private string _nazwa;
        public virtual string Nazwa
        {
            get { return _nazwa; }
            set { SetField(ref _nazwa, value, () => Nazwa); }
        }
    }
}