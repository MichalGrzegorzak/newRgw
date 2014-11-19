using System.Windows.Forms;

namespace Kanc.MVP.Presentation.Customers
{
    public interface IMyBaseView
    {
        int Id { get; set; }
        bool IsNew { get; set; }
        string Message { get; set; }

        string ViewName { get; set; }
        void NotifyUser(string message);
        void ClearView();

        void SetError(Control control, string message);
        void SetError(string ctrlName, string message);
    }
}