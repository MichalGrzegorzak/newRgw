using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Kanc.MVP.Core.Domain;
using Kanc.MVP.Tests.nHibernate.Core;
using NHibernate.Linq;
using NUnit.Framework;
using Utils.Extensions;

namespace Kanc.MVP.Tests.nHibernate
{
    [TestFixture]
    public class domain_tests : NHibernateFixtureBase
    {
        [Test]
        public void t1_dodaj_rozliczenia()
        {
            var r1 = CreateRozliczenie(11);
            var r2 = CreateRozliczenie(22);

            Session.SaveOrUpdate(r1);
            Session.SaveOrUpdate(r2);

            var l1 = r1.Lookup;

            // Assertion
            Session.Flush();
            Session.Clear();

            var fromDb = Session.Get<OsobaLookup>(l1.Id);

            Assert.AreNotSame(l1, fromDb);
            Assert.AreEqual(l1.Imie, fromDb.Imie);

            Assert.That(fromDb.Rozliczenies.Count(), Is.EqualTo(1));
        }

        

        [Test]
        public void t2_dodaj_rozliczenia_dla_tej_samej_osoby()
        {
            Osoba o1 = new Osoba() {Imie = "personA"};
            OsobaLookup l1 = new OsobaLookup(o1);
            var r1 = CreateRozliczenie(11, o1);
            var r2 = CreateRozliczenie(22, o1);
            var r3 = CreateRozliczenie(33, o1);

            r1.Lookup = l1;
            r2.Lookup = l1;
            r3.Lookup = l1;

            Session.SaveOrUpdate(l1);
            //
            Session.SaveOrUpdate(r1);
            Session.SaveOrUpdate(r2);
            Session.SaveOrUpdate(r3);

            // Assertion
            Session.Flush();
            Session.Clear();

            var fromDb = Session.Get<OsobaLookup>(r1.Lookup.Id);

            Assert.AreNotSame(l1, fromDb);
            Assert.AreEqual(l1.Imie, fromDb.Imie);

            Assert.That(fromDb.Rozliczenies.Count(), Is.EqualTo(3));
        }

        [Test]
        public void t3_dodaj_bank()
        {
            Bank b1 = new Bank() { Adres = "bb1", Kraj = Kraje.PL };
            Bank b2 = new Bank() { Adres = "bb2", Kraj = Kraje.DE };

            Session.SaveOrUpdate(b1);
            Session.SaveOrUpdate(b2);
            Session.Flush();
            Session.Clear();

            var fromDb = Session.Query<Bank>().Where(x => x.Id > 0);
            Assert.That(fromDb.Count(), Is.EqualTo(2));
        }

        [Test]
        public void t4_rozliczenie_experiments()
        {
            var r1 = CreateRozliczenie(11);
            r1.Partner.Imie = "franek";
            r1.Konto.AssignFrom(new Bank() { Blz = "12345", Nazwa = "PKO" });
            r1.Klient.Rozliczenie.Klient.Steuernummer = 2233.ToString();

            Session.SaveOrUpdate(r1);
            Session.Flush();
            Session.Clear();

            var fromDb = Session.Query<Rozliczenie>().Where(x => x.Id > 0).Single();
            Assert.That(fromDb.Id, Is.EqualTo(1));
            Assert.That(fromDb.Klient.Steuernummer, Is.EqualTo(2233.ToString()));
        }

        private static Rozliczenie CreateRozliczenie(int discriminator, Osoba person = null)
        {
            Adres a1 = new Adres() { Kod = discriminator.ToString() };
            var r1 = new Rozliczenie() { Rok = 2000 + discriminator };

            if (person == null)
            {
                person = new Osoba() { Imie = "koles" + discriminator };
                OsobaLookup l1 = new OsobaLookup(person);

                r1.Lookup = l1;
                r1.Klient.AssignFrom(person);
            }

            r1.Klient.AdresZameld.AssignFrom(a1);
            r1.Konto.BankAdres = "adresBanku" + discriminator;

            return r1;
        }
    }
}
