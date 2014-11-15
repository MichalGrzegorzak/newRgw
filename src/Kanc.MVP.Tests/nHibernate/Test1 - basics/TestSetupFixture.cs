using Kanc.MVP.Tests.nHibernate.Core;
using NUnit.Framework;

namespace Kanc.MVP.Tests.nHibernate
{
    [SetUpFixture]
    public class TestSetupFixture
    {
        [SetUp]
        public void Setup()
        {
            System.Environment.SetEnvironmentVariable("PreLoadSQLite_BaseDirectory", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            InMemorySessionFactoryProvider.Instance.Initialize();
        }

        [TearDown]
        public void TestTeardown()
        {
            InMemorySessionFactoryProvider.Instance.Dispose();
        }
    }
}