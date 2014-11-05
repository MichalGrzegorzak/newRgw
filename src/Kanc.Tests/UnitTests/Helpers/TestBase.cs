using System;
using System.Collections;
using System.Reflection;
using Kanc.Core;
using log4net;
using log4net.Config;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Engine;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Validator.Cfg;
using NHibernate.Validator.Engine;
using NUnit.Framework;

namespace Kanc.Test
{
	/// <summary>
	/// Ported from NH oficial tests.
	/// </summary>
	public abstract class TestBase
	{
		private const bool OutputDdl = false;
		protected Configuration cfg;
		protected ISessionFactory sessions;

		private static readonly ILog log = LogManager.GetLogger(typeof(TestBase));

		private ISession lastOpenedSession;
        private const string ConfigFile = "hibernate.cfg.xml";
		//private DebugConnectionProvider connectionProvider;


		/// <summary>
		/// Mapping files used in the TestCase
		/// </summary>
		protected abstract IList Mappings { get; }

		/// <summary>
		/// Assembly to load mapping files from (default is NHibernate.DomainModel).
		/// </summary>
		protected virtual string MappingsAssembly
		{
			get { return "Kanc.Core"; }
		}

		public ISession LastOpenedSession
		{
			get { return lastOpenedSession; }
		}

        static TestBase()
		{
			XmlConfigurator.Configure();
		}

		/// <summary>
		/// Creates the tables used in this TestCase
		/// </summary>
		[TestFixtureSetUp]
		public void TestFixtureSetUp()
		{
			try
			{
                Initialize();

                //Configure();
				//ConfigureIoC();
				//CreateSchema();
				//BuildSessionFactory();
                //connectionProvider = ((ISessionFactoryImplementor)sessions).ConnectionProvider as DebugConnectionProvider;
			}
			catch (Exception e)
			{
				log.Error("Error while setting up the test fixture", e);
				throw;
			}
		}

        private void Initialize()
        {
            // To see the SQLs run the application inside VisualStudio
            // watching the Output window
            //XmlConfigurator.Configure();
            ////new FileInfo("log4net.config")

            //var conf = new Configuration().Configure(ConfigFile);
            Configure();

            CreateSchema();

            ConfigureNHibernateValidator();
            ValidatorInitializer.Initialize(cfg);

            BuildSessionFactory();
        }

        private static void ConfigureNHibernateValidator()
        {
            XmlConfiguration validatorConf = new XmlConfiguration();
            validatorConf.Properties[NHibernate.Validator.Cfg.Environment.ApplyToDDL] = "true";
            validatorConf.Properties[NHibernate.Validator.Cfg.Environment.AutoregisterListeners] = "true";
            validatorConf.Properties[NHibernate.Validator.Cfg.Environment.ValidatorMode] = "UseAttribute";

            ValidatorEngine validator = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();
            validator.Configure(validatorConf);

            Context.Validator = validator;
        }

        //private static void ConfigureIoC()
        //{
        //    IWindsorContainer container = new WindsorContainer(new XmlInterpreter("core.config"));
        //    var conversationFactory = container.Resolve<IConversationFactory>();
        //    IoC.RegisterResolver(new WindsorDependencyResolver(container));
        //}

		/// <summary>
		/// Removes the tables used in this TestCase.
		/// </summary>
		/// <remarks>
		/// If the tables are not cleaned up sometimes SchemaExport runs into
		/// Sql errors because it can't drop tables because of the FKs.  This 
		/// will occur if the TestCase does not have the same hbm.xml files
		/// included as a previous one.
		/// </remarks>
		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			DropSchema();
			Cleanup();
		}

		protected virtual void OnSetUp()
		{
		}

		/// <summary>
		/// Set up the test. This method is not overridable, but it calls
		/// <see cref="OnSetUp" /> which is.
		/// </summary>
		[SetUp]
		public void SetUp()
		{
			OnSetUp();
		}

		protected virtual void OnTearDown()
		{
		}

		/// <summary>
		/// Checks that the test case cleans up after itself. This method
		/// is not overridable, but it calls <see cref="OnTearDown" /> which is.
		/// </summary>
		[TearDown]
		public void TearDown()
		{
			OnTearDown();

			bool wasClosed = CheckSessionWasClosed();
			bool wasCleaned = CheckDatabaseWasCleaned();
			//bool wereConnectionsClosed = CheckConnectionsWereClosed();
		    bool fail = !wasClosed || !wasCleaned;
                //|| !wereConnectionsClosed;

			if (fail)
			{
				Assert.Fail("Test didn't clean up after itself");
			}
		}

		private bool CheckSessionWasClosed()
		{
			if (lastOpenedSession != null && lastOpenedSession.IsOpen)
			{
				log.Error("Test case didn't close a session, closing");
				lastOpenedSession.Close();
				return false;
			}

			return true;
		}

		private bool CheckDatabaseWasCleaned()
		{
			if (sessions.GetAllClassMetadata().Count == 0)
			{
				// Return early in the case of no mappings, also avoiding
				// a warning when executing the HQL below.
				return true;
			}

			bool empty;
			using (ISession s = sessions.OpenSession())
			{
				IList objects = s.CreateQuery("from System.Object o").List();
				empty = objects.Count == 0;
                if (!empty)
                {
                    log.Error("Test case didn't clean up the database after itself, re-creating the schema");
                }
			}

			if (!empty)
			{
				DropSchema();
				CreateSchema();
			}

			return empty;
		}

        //private bool CheckConnectionsWereClosed()
        //{
        //    if (connectionProvider == null || !connectionProvider.HasOpenConnections)
        //    {
        //        return true;
        //    }

        //    log.Error("Test case didn't close all open connections, closing");
        //    connectionProvider.CloseAllConnections();
        //    return false;
        //}

		protected virtual void Configure()
		{
			cfg = new Configuration();
			Assembly assembly = Assembly.Load(MappingsAssembly);
			Configure(cfg);

			foreach (string file in Mappings)
			{
				cfg.AddResource(MappingsAssembly + "." + file, assembly);
			}

		}

		private void CreateSchema()
		{
			new SchemaExport(cfg).Create(OutputDdl, true);
		}

		private void DropSchema()
		{
			new SchemaExport(cfg).Drop(OutputDdl, true);
		}

		protected virtual void BuildSessionFactory()
		{
			//sessions = cfg.BuildSessionFactory();
			//connectionProvider = sessions.ConnectionProvider as DebugConnectionProvider;

            //interceptor ma zaimplementowac INotifyPropertyChange dla Entities
            //var intercepter = new DataBindingIntercepter();
            sessions = cfg
                //.SetInterceptor(intercepter)
                .BuildSessionFactory();

            //intercepter.SessionFactory = sessions;

            Context.SessionFactory = sessions;
		}

		private void Cleanup()
		{
			sessions.Close();
			sessions = null;
			//connectionProvider = null;
			lastOpenedSession = null;
			cfg = null;
		}

		protected virtual ISession OpenSession()
		{
			lastOpenedSession = sessions.OpenSession();
			return lastOpenedSession;
		}

		#region Properties overridable by subclasses
		protected virtual void Configure(Configuration configuration)
		{
			configuration.Configure();
		}

		#endregion
	}
}
