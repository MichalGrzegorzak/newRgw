using FluentNHibernate;
using Kanc.MVP.Core.nHibernate.SessionProviders;
using NHibernate;
using NUnit.Framework;

namespace Kanc.MVP.Tests.nHibernate.Core
{
    public class NHibernateFixtureBase
    {
        protected SessionSource SessionSource { get; set; }
        protected ISession Session { get; private set; }

        [TestFixtureSetUp]
        public void OnetimeInit()
        {
            System.Environment.SetEnvironmentVariable("PreLoadSQLite_BaseDirectory", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            InMemorySessionFactoryProvider.Instance.Initialize();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            InMemorySessionFactoryProvider.Instance.Dispose();
        }

        [SetUp]
        public void SetupContext()
        {
            Before_each_test();
        }

        [TearDown]
        public void TearDownContext()
        {
            After_each_test();
        }

        protected virtual void Before_each_test()
        {
            Session = InMemorySessionFactoryProvider.Instance.OpenSession();

            CreateInitialData(Session);
            Session.Flush();
            Session.Clear();
        }

        protected virtual void After_each_test()
        {
            Session.Close();
            Session.Dispose();
        }

        protected virtual void CreateInitialData(ISession session)
        {
        }
    }

    public class TestModel : PersistenceModel
    {
        public TestModel()
        {
            //AddMappingsFromThisAssembly();
        }
    }
}