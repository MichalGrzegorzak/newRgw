using System;
using System.Reflection;
using System.Windows.Forms;
using Customization.ApplicationLogic;
using MVCSharp.Core.Configuration;
using MVCSharp.Core.Tasks;

namespace Customization.Presentation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MVCConfiguration cfg = OutlookLikeViewsManager.GetDefaultConfig();
            cfg.ViewsAssemblies.Add(Assembly.Load(
                    "Customization.SeparateViews"));
            cfg.TaskInfoProviderType = typeof(TaskInfoByAttributesProviderEx);
            cfg.ViewInfosProviderType = typeof(ViewInfosPrividerEx);
            (new TasksManager(cfg)).StartTask(typeof(MainTask));
            Application.Run(Application.OpenForms[0]);
        }
    }
}