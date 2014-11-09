using Kanc.MVP.Controllers;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Customers
{
    [ViewEx(typeof(MainTask), MainTask.SearchCustomer, null, ShowModal = true)]
    public partial class SearchForm : WinFormView, ISearchFormView
    {
        public SearchForm()
        {
            InitializeComponent();
        }


    }
}
