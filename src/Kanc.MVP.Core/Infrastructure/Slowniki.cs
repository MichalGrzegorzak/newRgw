using System.Collections.Generic;
using Kanc.MVP.Core.Domain.Entities;

namespace Kanc.MVP.Core.Infrastructure
{
    public sealed class Slowniki
    {
        //#region Singleton
        //private static readonly Slowniki _inst = new Slowniki();

        //public static Slowniki Inst
        //{
        //    get { return _inst; }
        //}

        //private Slowniki()
        //{
        //    Initialize();
        //} 
        //#endregion

        public Biuro Biuro = new Biuro();

        public void Initialize(ISession session)
        {
            //var kraje = session.CreateQuery("from Kraj").Future<Kraj>();
            //var polecajacy = session.CreateQuery("from Polecil").Future<Polecil>();
            var banki = session.CreateQuery("from Bank").Future<Bank>();
            //_kraje = new List<Kraj>(kraje);
            //_polecajacy = new List<Polecil>(polecajacy);
            _banki = new List<Bank>(banki);
            //kraje.Add(new Kraj());
        }

        List<Kraje> _kraje = new List<Kraje>();
        //List<Polecil> _polecajacy = new List<Polecil>();
        List<Bank> _banki = new List<Bank>();

        public List<Kraje> Kraje
        {
            get { return _kraje; }
        }
        
        public List<Bank> Banki
        {
            get { return _banki; }
        }

    }
}
