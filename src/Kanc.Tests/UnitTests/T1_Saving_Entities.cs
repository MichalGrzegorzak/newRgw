using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.Test;
using NHibernate;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace Kanc.Tests
{
    public class Saving_Entities : TestBase
    {
        protected override IList Mappings
        {
            get { return new ArrayList(); }
        }

        protected override void OnTearDown()
        {
            using (var session = sessions.OpenSession())
            {
                session.Delete("from Bank");
                session.Delete("from Klient");
                session.Delete("from Polecil");
                session.Delete("from Adres");
                session.Flush();
            }
        }

        [Test]
        public void Can_save_Klient()
        {
            Klient fromDb;
            var klient = EntitiesFactory.MakeKlient();

            using (var s = sessions.OpenSession())
            {
                s.Save(klient);
                fromDb = s.Get<Klient>(klient.Id);
            }
            Assert.That(fromDb.GetErrors().Count(), Is.LessThanOrEqualTo(0));

            using (var s = sessions.OpenSession())
            {
                s.Delete(fromDb);
                //s.Delete(fromDb.PoleconyPrzez); //this will not get deleted by cascade
                s.Flush();
            }
            using (var s = sessions.OpenSession())
            {
                fromDb = s.Get<Klient>(klient.Id);
                Assert.That(fromDb, Is.Null);
            }
                
        }

        [Test]
        public void Can_save_bank()
        {
            Bank fromDb;
            var bank = EntitiesFactory.MakeBank();
            bool v = bank.IsValid();

            using (var s = sessions.OpenSession())
            {
                s.Save(bank);
                fromDb = s.Get<Bank>(bank.Id);
            }
            Assert.That(fromDb.GetErrors().Count(), Is.LessThanOrEqualTo(0)); //no errors

            //after delete
            using (var s = sessions.OpenSession())
            {
                s.Delete(fromDb);
                s.Flush();
            }
            using (var s = sessions.OpenSession())
            {
                fromDb = s.Get<Bank>(bank.Id);
                Assert.That(fromDb, Is.Null);
            }

        }


        [Test]
        public void Can_save_Rozliczenie()
        {
            Rozliczenie fromDb;
            var roz = EntitiesFactory.MakeRozliczenie1();

            int i = roz.GetErrors().Count();
            using (var s = sessions.OpenSession())
            {
                s.Save(roz);
                fromDb = s.Get<Rozliczenie>(roz.Id);
            }
            Assert.That(fromDb.GetErrors().Count(), Is.LessThanOrEqualTo(0));

            using (var s = sessions.OpenSession())
            {
                s.Delete(fromDb);
                s.Delete(fromDb.Klient); //this will not get deleted by cascade
                s.Flush();
            }
        }

        
    }
}
