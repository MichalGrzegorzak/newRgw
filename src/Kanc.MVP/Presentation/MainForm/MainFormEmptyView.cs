using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.MVP.Controllers;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Winforms;
using Kanc.MVP.Presentation.MainForm;

namespace Kanc.MVP.Presentation.Client
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
