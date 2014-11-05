using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Kanc.MVP.Controllers;
using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Presentation.Client;
using Kanc.MVP.Presentation.MainForm;
using Kanc.MVP.Presentation.Note;
using Kanc.MVP.Presentation.Task;
using Kanc.MVP.Properties;
using MVCSharp.Core.Configuration;
using MVCSharp.Core.Views;
using MVCSharp.Winforms;
using MVCSharp.Winforms.Configuration;
using Owf.Controls;

namespace Kanc.MVP.Engine.ViewManager
{
    public class OutlookLikeViewsManager : WinformsViewsManager, IDynamicViewsManager
    {
        OutlookPanelEx contentPanel;

        public void RegisterMasterView(MainForm form)
        {
            contentPanel = form.Controls["contentPanel"] as OutlookPanelEx;
        }

        protected override void InitializeFormView(Form form, WinformsViewInfo viewInf)
        {
            base.InitializeFormView(form, viewInf);
            // If it's main form then access its content panel.
            if (form is MainForm)
                contentPanel = form.Controls["contentPanel"] as OutlookPanelEx;
            else
            {
                return;
            }
        }

        protected override void InitializeUserControlView(UserControl ucView)
        {
            base.InitializeUserControlView(ucView);
            if (ucView.Parent != null) 
                return;
            ucView.Parent = contentPanel;
            ucView.Dock = DockStyle.Fill;
        }

        protected override void ActivateUserControlView(IView view)
        {
            base.ActivateUserControlView(view);
            (view as UserControl).BringToFront();

            string imgName = (ViewInfos[view.ViewName] as ViewInfoEx).ImgName;

            if (contentPanel != null)
            {
                contentPanel.HeaderText = view.ViewName;
                contentPanel.Icon = Resources.ResourceManager.GetObject(imgName) as Image;
            }
        }

        new public static MVCConfiguration GetDefaultConfig()
        {
            MVCConfiguration defaultConf = WinformsViewsManager.GetDefaultConfig();
            defaultConf.ViewsAssembly = Assembly.GetCallingAssembly();
            defaultConf.ViewsManagerType = typeof(OutlookLikeViewsManager);
            return defaultConf;
        }

        public InteractionPointInfoEx CreateView(ViewCategory vc)
        {
            InteractionPointInfoEx result = new InteractionPointInfoEx();
            result.ViewName = vc.ToString() + " " + (ViewInfos.Count-1).ToString();
            result.IsCommonTarget = true;
            result.ViewCategory = vc;
            Navigator.TaskInfo.InteractionPoints[result.ViewName] = result;
            ViewInfoEx vi = new ViewInfoEx(result.ViewName, "", null);
            switch (vc)
            {
                case ViewCategory.OrderEdit:
                    vi.ImgName = "Mail"; vi.ViewType = typeof(EditOrder); break;
                case ViewCategory.Klient:
                    vi.ImgName = "Mail"; vi.ViewType = typeof(ClientSearch); break;
                case ViewCategory.Raporty:
                    vi.ImgName = "Notes"; vi.ViewType = typeof(NoteView); break;
                case ViewCategory.Tasks:
                    vi.ImgName = "Tasks"; vi.ViewType = typeof(TaskView); break;                    
            }
            ViewInfos.Add(vi);
            return result;
        }

    }
}
