using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

using Kanc.MVP.Core.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Engine.ViewManager;
using MVCSharp.Core.Configuration;
using MVCSharp.Core.Tasks;

namespace Kanc.MVP
{
    // The class that handles the creation of the application windows
    // Taken from http://msdn.microsoft.com/en-us/library/system.windows.forms.application.run.aspx
    class AppContext : ApplicationContext
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private AppContext()
        {
            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += OnApplicationExit;
             // Catch all unhandled exceptions
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
             // Catch all unhandled exceptions in all threads.
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Initialize();
        }

        private void Initialize()
        {
            //BootStrapper.Initialize();
            //SlownikiInitialize();

            CreateTestData();

            InitMVCSharp();
        }

        private void InitMVCSharp()
        {
            MVCConfiguration cfg = OutlookLikeViewsManager.GetDefaultConfig();
            //cfg.ViewsAssemblies.Add(Assembly.Load("Kanc.MVP.SeparateViews"));

            cfg.TaskInfoProviderType = typeof(TaskInfoByAttributesProviderEx);
            cfg.ViewInfosProviderType = typeof(ViewInfosPrividerEx);

            (new TasksManager(cfg)).StartTask(typeof(MainTask));
            var startForm = Application.OpenForms[0];
            startForm.Closed += OnFormClosed;
        }

        private static void CreateTestData()
        {
            var o1 = new Osoba() {Nazwisko = "John"};
            var o2 = new Osoba() {Nazwisko = "Paul"};
            var o3 = new Osoba() {Nazwisko = "Snow"};
            var o4 = new Osoba() {Nazwisko = "Snow1"};
            var o5 = new Osoba() {Nazwisko = "Snow2"};
            
            OsobaLookup.AllCustomers.Add(new OsobaLookup(o1));
            OsobaLookup.AllCustomers.Add(new OsobaLookup(o2));
            OsobaLookup.AllCustomers.Add(new OsobaLookup(o3));
            OsobaLookup.AllCustomers.Add(new OsobaLookup(o4));
            OsobaLookup.AllCustomers.Add(new OsobaLookup(o5));

            var r1 = new Rozliczenie(); 
            r1.Klient.AssignFrom(o3);
            var r2 = new Rozliczenie();
            r2.Klient.AssignFrom(o3);
            var r3 = new Rozliczenie();
            r3.Klient.AssignFrom(o3);

            var r4 = new Rozliczenie();
            r4.Klient.AssignFrom(o1);
            var r5 = new Rozliczenie();
            r5.Klient.AssignFrom(o1);

            OsobaLookup.AllCustomers[2].Rozliczenies.Add(r1);
            OsobaLookup.AllCustomers[2].Rozliczenies.Add(r2);
            OsobaLookup.AllCustomers[2].Rozliczenies.Add(r3);
        }

        //private void SlownikiInitialize()
        //{
        //    Context.Slownik = new Slowniki();
        //    ISession session = Context.SessionFactory.OpenSession();
        //    using(var tx = session.BeginTransaction())
        //    {
        //        Context.Slownik.Initialize(session);
        //        tx.Commit();
        //        session.Close();
        //    }
        //}

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            //This is the last thing called         
            Trace.WriteLine("OnApplicationExit");
        }

        private static void OnFormClosing(object sender, CancelEventArgs e)
        {
            Trace.WriteLine("OnFormClosing()");
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Trace.WriteLine("OnFormClosed() - Closing the message loop of this thread");
            ExitThread();
        }


        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            // Create the AppContext, that derives from ApplicationContext,
            // that manages when the application should exit.
            var context = new AppContext();

            // Run the application with the specific context. It will exit when
            // all forms are closed.
            Application.Run(context);
        }

        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception x = (Exception)e.ExceptionObject;
                log.Error("Blad aplikacji.", x);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                MessageBox.Show("Uwaga, wystapił blad! \r\n" + e.Exception);
                log.Error("Blad w watku.", e.Exception);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
    }
}
