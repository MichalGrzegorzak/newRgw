using Kanc.MVP.Controllers;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Customers
{
    [ViewEx(typeof(SearchTask), SearchTask.Start, null, ShowModal = true)]
    public partial class SearchForm : WinFormView, ISearchFormView
    {
        public SearchForm()
        {
            InitializeComponent();

            this.searchCustomer1.CloseTriggered += searchCustomer1_CloseTriggered;
        }

        void searchCustomer1_CloseTriggered(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
