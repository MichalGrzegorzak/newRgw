using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.UI.Forms;
using NHibernate;

namespace Kanc.UI
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

            
            Context.IsTestingMode = false;
            Context.IsReportTestingMode = false;
            
            NormalInitialize();
            //UITestingInitialize();

            //form.View.Closing += OnFormClosing;
        }

        private void NormalInitialize()
        {
            BootStrapper.Initialize();

            SlownikiInitialize();

            Trace.WriteLine("");

            //var form = new MainForm();
            //form.Show();
            //form.Closed += OnFormClosed;

            UIContext.MainForm = new MainForm();
            UIContext.MainForm.Closed += OnFormClosed;
            UIContext.MainForm.Show();

            
        }

        private void UITestingInitialize()
        {
            SlownikiInitialize();

            Rozliczenie r = new Rozliczenie();
            EdycjaKlienta form = new EdycjaKlienta(null, r);
            form.AutoScroll = true;

            form.Show();
        }


        

        private void SlownikiInitialize()
        {
            Context.Slownik = new Slowniki();
            ISession session = Context.SessionFactory.OpenSession();
            using(var tx = session.BeginTransaction())
            {
                Context.Slownik.Initialize(session);
                tx.Commit();
                session.Close();
            }
            
        }

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
