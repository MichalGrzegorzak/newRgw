using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Kanc.MVP.Controllers.Main;
using Kanc.MVP.Engine.InteractionPoint;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Properties;
using MT.WindowsUI.NavigationPane;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.MainForm
{
    [ViewEx(typeof(MainTask), MainTask.MainView, "", IsMdiParent = true)]
    public partial class MainForm : WinFormViewForMainViewController, IMainView
    {
        private ListView lvKlient = new ListView();
        private ListView lvNotes = new ListView();
        private ListView lvSzukaj = new ListView();

        private ImageList imgList = new ImageList();

        public MainForm()
        {
            InitializeComponent();
            SetupNavPane();
        }

        private void SetupNavPane()
        {
            navigateBar.NavigateBarButtons[0].RelatedControl = lvKlient;
            navigateBar.NavigateBarButtons[1].RelatedControl = lvNotes;
            navigateBar.NavigateBarButtons[2].RelatedControl = lvSzukaj;
            setupListView(lvKlient);
            setupListView(lvNotes);
            setupListView(lvSzukaj);

            //navigateBar.SelectedButton = navigateBar.NavigateBarButtons[1];
            //navigateBar.SelectedButton = navigateBar.NavigateBarButtons[0];

            //hack - inaczej nie zmieni
            ShowViewCategory(ViewCategory.Druki);
            ShowViewCategory(ViewCategory.Klient);
        }

        private void setupListView(ListView lv)
        {
            lv.View = View.SmallIcon;
            lv.Activation = ItemActivation.OneClick;
            lv.BorderStyle = BorderStyle.None;
            lv.SmallImageList = imgList;
            lv.ItemActivate += navBarListView_ItemActivate;
        }

        /// <summary>
        /// Click on one of listview actions
        /// </summary>
        void navBarListView_ItemActivate(object sender, EventArgs e)
        {
            Controller.NavigateToView((sender as ListView).FocusedItem.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolStripManager.Renderer = new Office2007Renderer.Office2007Renderer();
        }

        public override void Initialize()
        {
            //LoadAvailableActions(true);
        }

        public void LoadAvailableActions(bool takeOnlyCommonTargets)
        {
            lvKlient.Items.Clear();
            lvNotes.Items.Clear();
            lvSzukaj.Items.Clear();
            
            TaskInfo ti = Controller.Task.Navigator.TaskInfo;
            var list = ti.InteractionPoints.Cast<InteractionPointInfoEx>();

            //if (takeOnlyCommonTargets)
            list = list.Where(x => x.IsCommonTarget == takeOnlyCommonTargets);

            foreach (InteractionPointInfoEx ip in list)
                AddViewToNavPane(ip);
        }

        public void AddViewToNavPane(InteractionPointInfoEx ip)
        {
            TaskInfo ti = Controller.Task.Navigator.TaskInfo;
            if (ip.ViewCategory == ViewCategory.None)
                return;

            ViewInfoEx vi = ti.ViewInfos[ip.ViewName] as ViewInfoEx;
            //if (vi.ImgName != null)
            {
                Image i = Resources.ResourceManager.GetObject(vi.ImgName) as Image;
                imgList.Images.Add(ip.ViewName, i);
            }
            ListView lv = lvKlient;
            switch (ip.ViewCategory)
            {
                case ViewCategory.Klient: lv = lvKlient; break;
                case ViewCategory.Druki: lv = lvNotes; break;
                //case ViewCategory.Szukaj: lv = lvSzukaj; break;
                //case ViewCategory.Tasks: lv = lvTasks; break;
            }
            lv.Items.Add(ip.ViewName, ip.ViewName);
            //lv.Items[0].Font = new Font(lv.Items[0].Font, FontStyle.Bold);
        }

        private void navigateBar_OnNavigateBarButtonSelected(NavigateBarButton tNavigateBarButton)
        {
            CurrentCategoryChanged(tNavigateBarButton.Caption);
        }

        public void CurrentCategoryChanged(string catName)
        {
            ViewCategory selectedCat = (ViewCategory)Enum.Parse(typeof(ViewCategory), catName);
            switch (selectedCat)
            {
                case ViewCategory.Klient:
                    navigateBar.SelectedButton = navigateBar.NavigateBarButtons[0];
                    CheckToolBarCategoryButtons(true, false, false); break;
                //case ViewCategory.Szukaj:
                //    navigateBar.SelectedButton = navigateBar.NavigateBarButtons[1];
                //    CheckToolBarCategoryButtons(false, true, false);
                //    //Controller.StartSearch();
                //    break;
                case ViewCategory.Druki:
                    navigateBar.SelectedButton = navigateBar.NavigateBarButtons[2];
                    CheckToolBarCategoryButtons(false, false, true); break;
                default:
                    throw new Exception("Brak akcji !");
                    //case ViewCategory.Tasks:
                    //    navigateBar.SelectedButton = navigateBar.NavigateBarButtons[2];
                    //    CheckToolBarCategoryButtons(false, false, true); break;
            }
        }

        private void CheckToolBarCategoryButtons(bool klientChecked, bool drukujChecked, bool szukajChecked)
        {
            nowyKlientToolStripButton.Checked = klientChecked;
            szukajToolStripButton.Checked = szukajChecked;
            notesToolStripButton.Checked = drukujChecked;
        }

        public void ShowViewCategory(ViewCategory cat)
        {
            var btn = navigateBar.NavigateBarButtons.FindByKey(cat.ToString());
            btn.PerformClick();
        }

        private void catToolStripItem_Click(object sender, EventArgs e)
        {
            CurrentCategoryChanged((sender as ToolStripItem).Text);
        }

        private void nowyKlientToolStripButton_Click(object sender, EventArgs e)
        {
            LoadAvailableActions(false);
            CurrentCategoryChanged(ViewCategory.Klient.ToString());

            Controller.NavigateToView(MainTask.NewCustomer);
            //Controller.CreateView(ViewCategory.NowyKlient);
        }

        private void szukajToolStripButton_Click(object sender, EventArgs e)
        {
            Controller.StartSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new Exception("testing exceptions");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

    }

    public class WinFormViewForMainViewController : WinFormView<MainViewController> { }
}