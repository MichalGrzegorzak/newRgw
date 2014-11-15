using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using log4net.Config;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;

namespace Kanc.MVP.Core.Infrastructure.Setup
{
	public class BootStrapper
	{
		private const string SerializedConfiguration = "configurtion.serialized";
		private const string ConfigFile = "hibernate.cfg.xml";
		//private static Configuration Configuration { get; set; }

		private static void ConfigureNHibernateValidator()
		{
			var types = Assembly.Load("Kanc.MVP.Core").GetTypes()
				.Where(t => t.FullName.StartsWith("Kanc.Core.Entities.Validation"));


            var nhibernateConfig = new Configuration();
            var cfg = new SQLiteConfiguration()
                .InMemory()
                .ConfigureProperties(nhibernateConfig);

            //var sessionSource = new SessionSource(cfg.Properties, new MyPersistenceModel());

            //using (var session = sessionSource.CreateSession())
            //{
            //    var product = new Product { Name = "Product 1", UnitPrice = 10.55m, Discontinued = false };
            //    session.Save(product);
            //}

    //        var cfg = new MyConfiguration()
    //.ShowSql()
    //.Driver<SQLite20Driver>()
    //.Dialect<SQLiteDialect>()
    //.ConnectionString.Is("Data Source=:memory:;Version=3;New=True;")
    //.Raw("connection.release_mode", "on_close");

            //var config = new FluentConfiguration.
            //config
            //    .Register(types.ValidationDefinitions())
            //    .SetDefaultValidatorMode(ValidatorMode.UseExternal)
            //    //.AddEntityTypeInspector<NHVTypeInspector>() 
            //    .IntegrateWithNHibernate
            //    .And.RegisteringListeners();

			//var validator = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();
			//validator.Configure(config);
			//Context.Validator = validator;
		}

		private static Configuration ConfigureNHibernate()
		{
			var conf = new Configuration().Configure(ConfigFile);

			// Validate the schema: if wrong try to create the new schema
			try
			{
				new SchemaValidator(conf).Validate();
			}
			catch (HibernateException ex)
			{
				var s = ex.Message;
			    RecreateDB(conf);
			}
		
			return conf;
		}

        public static void RecreateDB(Configuration conf)
        {
            var export = new SchemaExport(conf);
            export.Drop(false, true);
            export.Create(false, true);
        }

		public static void Initialize()
		{
			#region Configuration Log4Net

			// To see the SQLs run the application inside VisualStudio
			// watching the Output window
			XmlConfigurator.Configure(new FileInfo("log4net.config"));

			#endregion

			var usedCfg = true;
			var conf = LoadConfigurationFromFile();
			if (conf == null)
			{
				conf = ConfigureNHibernate();
				SaveConfigurationToFile(conf);
				usedCfg = false;
			}

			Thread.CurrentThread.CurrentCulture = new CultureInfo("Pl-pl");
			ConfigureNHibernateValidator();
			//ValidatorInitializer.Initialize(conf); //powiazanie z hibernatem

			Context.FactoryInitializer = new SessionFactoryInitializer(conf);
			Context.FactoryInitializer.SetupNormal();
			//Context.FactoryInitializer.SetupDynamicProxy();
		}

		private static bool IsConfigurationFileValid
		{
			get
			{
				var ass = Assembly.GetCallingAssembly();
				if (ass.Location == null)
					return false;
				var configInfo = new FileInfo(SerializedConfiguration);
				var assInfo = new FileInfo(ass.Location);
				var configFileInfo = new FileInfo(ConfigFile);
				if (configInfo.LastWriteTime < assInfo.LastWriteTime)
					return false;
				if (configInfo.LastWriteTime < configFileInfo.LastWriteTime)
					return false;
				return true;
			}
		}

		private static void SaveConfigurationToFile(Configuration configuration)
		{
			using(var file = File.Open(SerializedConfiguration, FileMode.Create))
			{
				var bf = new BinaryFormatter();
				bf.Serialize(file, configuration);
			}
		}

		private static Configuration LoadConfigurationFromFile()
		{
            // TODO -> NARAZIE WYLACZAM, aby START byl szybszy !!!
            //if (IsConfigurationFileValid == false)
            //    return null;

			try
			{
				using(var file = File.Open(SerializedConfiguration, FileMode.Open))
				{
					var bf = new BinaryFormatter();
					return bf.Deserialize(file) as Configuration;
				}
			}
			catch (Exception)
			{
				return null;
			}
		}
	}

    public class MyConfiguration : PersistenceConfiguration<MyConfiguration>
    {
    }

    
}