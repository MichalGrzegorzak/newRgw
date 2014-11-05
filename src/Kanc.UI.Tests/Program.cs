using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Kanc.UI.Tests;
using Kanc.UI.Tests.Forms;

namespace Kanc.UI.Tests
{
    class AppContext : ApplicationContext
    {
        private AppContext()
        {
            BootStrapper.Initialize();

            Trace.WriteLine("go");
            //var form = Presenters.Show("Main");
            new MainFrm().Show();
            //var form = Presenters.Show("Main", 5);
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
