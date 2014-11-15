using System;
using System.Linq;
using Kanc.MVP.Tests.nHibernate.Core;
using Kanc.MVP.Tests.nHibernate.Domain;
using Kanc.MVP.Tests.nHibernate.Domain.Enums;
using Kanc.MVP.Tests.nHibernate.Domain.Rozliczenie;
using NHibernate.Linq;
using NUnit.Framework;
using Utils.Extensions;

namespace Kanc.MVP.Tests.nHibernate
{
    [TestFixture]
    public class nh_domain_tests : NHibernateFixtureBase
    {
        //[Test]
        //public void t1_add_klient()
        //{
        //    Rozliczenie r1 = new Rozliczenie() { Status = Status.doZaplaty};
        //    var user1 = new Klient(r1) { Imie = "a"};

        //    Session.Save(user1);
        //    Session.Save(r1);

        //    // Assertion
        //    Session.Flush();
        //    Session.Clear();

        //    var fromDb = Session.Get<Rozliczenie>(r1.Id);

        //    Assert.AreNotSame(r1, fromDb);
        //    Assert.AreEqual(r1.Status, fromDb.Status);
        //}

        [Test]
        public void t1_add_adres()
        {
            Adres a1 = new Adres() { Kod = "11"};
            Bank b1 = new Bank() {Adres = "aa"};

            var r1 = new Rozliczenie() { Rok = 2011 };
            var r2 = new Rozliczenie() { Rok = 2012 };
            
            //Klient k1 = new Klient(r1) { Imie = "zenek" };
            Osoba o1 = new Osoba() { Imie = "dupa11"};
            Osoba o2 = new Osoba() { Imie = "dupa22" };
            OsobaLookup l1 = new OsobaLookup(o1);
            OsobaLookup l2 = new OsobaLookup(o2);
            Klient k1 = new Klient(o1);
            Klient k2 = new Klient(o2);

            k1.Rozliczenie = r1;

            //OsobaLookup l1 = new OsobaLookup() {Imie = "osoba1"};

            Session.Save(a1);
            Session.Save(b1);
            Session.Save(k1);
            Session.Save(k2);
            Session.Save(r1);

            Session.Save(r2);
            Session.Save(o1);
            Session.Save(o2);
            Session.Save(l1);
            Session.Save(l2);

            // Assertion
            Session.Flush();
            Session.Clear();

            var fromDb = Session.Get<Rozliczenie>(r1.Id);

            Assert.AreNotSame(r1, fromDb);
            Assert.AreEqual(r1.Rok, fromDb.Rok);
        }
        


    }
}
