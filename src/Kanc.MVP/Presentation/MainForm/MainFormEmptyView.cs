using Kanc.MVP.Controllers.Main;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.MainForm
{
    [ViewEx(typeof(MainTask), MainTask.MainViewEmpty, "New")]
    public partial class MainFormEmptyView : ucMainFormEmpty, IMainFormEmptyView
    {
        public MainFormEmptyView()
        {
            InitializeComponent();

            //txbId.Validating += ValidateInput;
        }
    }

    public class ucMainFormEmpty : WinUserControlView<MainViewEmptyController>
    { }
}
