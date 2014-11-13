using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Kanc.MVP.Domain;
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

            NormalInitialize();
            //UITestingInitialize();
        }

        private void NormalInitialize()
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
            Customer.AllCustomers.Add(new Customer("John"));
            Customer.AllCustomers.Add(new Customer("Paul"));
            Customer.AllCustomers.Add(new Customer("Snow"));
            Customer.AllCustomers.Add(new Customer("Snow1"));
            Customer.AllCustomers.Add(new Customer("Snow2"));

            Customer.AllCustomers[2].Orders.Add(new Order(1, "a"));
            Customer.AllCustomers[2].Orders.Add(new Order(2, "b"));
            Customer.AllCustomers[2].Orders.Add(new Order(3, "c"));

            Customer.AllCustomers[1].Orders.Add(new Order(4, "44"));
            Customer.AllCustomers[1].Orders.Add(new Order(5, "55"));
        }

        //private void UITestingInitialize()
        //{
        //    SlownikiInitialize();

        //    Rozliczenie r = new Rozliczenie();
        //    EdycjaKlienta form = new EdycjaKlienta(null, r);
        //    form.AutoScroll = true;

        //    form.Show();
        //}

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
