using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Threading;
using Kanc.Commons;
using Kanc.UI.Tests.Enitites;
using Kanc.UI.Tests.Infrastructure;
using Kanc.UI.Tests.Infrastructure.Setup;
using log4net.Config;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Event;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Engine;
using NHibernate.Validator.Cfg;
using NHibernate.Validator.Event;

namespace Kanc.UI.Tests
{
	public class BootStrapper
	{
		private const string SerializedConfiguration = "configurtion.serialized";
		private const string ConfigFile = "hibernate.cfg.xml";
		//private static Configuration Configuration { get; set; }

		public static void ConfigureNHibernateValidator()
		{
			//var validatorConf = new FluentConfiguration();
			//validatorConf
			//    .Register(
			//    Assembly.Load("Kanc.Core").GetTypes()
			//    .Where(t => t.FullName.StartsWith("Kanc.Core.Entities.Validation")))
			//            //typeof(KrajValidationDef).Assembly.ValidationDefinitions())
			//        .SetDefaultValidatorMode(ValidatorMode.OverrideAttributeWithExternal)
			//        .IntegrateWithNHibernate
			//        .ApplyingDDLConstraints()
			//        .And.RegisteringListeners();


			////validator jako fluent klasy

			var types = Assembly.Load("Kanc.UI.Tests").GetTypes()
				.Where(t => t.FullName.StartsWith("Kanc.UI.Tests"));

			var config = new FluentConfiguration();
			config
				.Register(types.ValidationDefinitions())
				.SetDefaultValidatorMode(ValidatorMode.OverrideAttributeWithExternal)
				.AddEntityTypeInspector<NHVTypeInspector>() 
				.IntegrateWithNHibernate
				.And.RegisteringListeners()
				;

			//konfiguruje validator jako atrybuty, binder niestety rowniez uzywa atrybutuow
			//XmlConfiguration config = new XmlConfiguration();
			//config.Properties[NHibernate.Validator.Cfg.Environment.ApplyToDDL] = "false";
			//config.Properties[NHibernate.Validator.Cfg.Environment.AutoregisterListeners] = "false";
			//config.Properties[NHibernate.Validator.Cfg.Environment.ValidatorMode] = "UseExternal";
			//    //"UseAttribute";

			var validator = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();
			validator.Configure(config);

			Context.Validator = validator;
		}

		public static Configuration ConfigureNHibernate()
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
				var export = new SchemaExport(conf);
				export.Drop(false, true);
				export.Create(false, true);
			}
		
			return conf;
		}

		public static void Initialize()
		{
			#region Configuration Log4Net

			// To see the SQLs run the application inside VisualStudio
			// watching the Output window
			XmlConfigurator.Configure(new FileInfo("log4net.config"));

			#endregion

			//READ FROM FILE
			//var usedCfg = true;
			//var conf = LoadConfigurationFromFile();
			//if (conf == null)
			//{
			//    conf = ConfigureNHibernate();
			//    SaveConfigurationToFile(conf);
			//    usedCfg = false;
			//}

			Thread.CurrentThread.CurrentCulture = new CultureInfo("PL-pl");
			var conf = ConfigureNHibernate();
			ConfigureNHibernateValidator();
			ValidatorInitializer.Initialize(conf);

			Context.FactoryInitializer = new SessionFactoryInitializer(conf);
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
			if (IsConfigurationFileValid == false)
				return null;
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
}