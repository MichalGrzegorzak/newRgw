using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Effectus.Infrastructure;

namespace Effectus
{
    // The class that handles the creation of the application windows
    // Taken from http://msdn.microsoft.com/en-us/library/system.windows.forms.application.run.aspx
    class AppContext : ApplicationContext
    {               
        private AppContext()
        {
            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += OnApplicationExit;

            BootStrapper.Initialize();

            Trace.WriteLine("");
            var form = Presenters.Show("Main");
            //var form = Presenters.Show("Main", 5);
            //TODO Need a better way to do this???
            form.View.Closed += OnFormClosed;
            //form.View.Closing += OnFormClosing;
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
    }
}
