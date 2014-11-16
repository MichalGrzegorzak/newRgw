using Kanc.MVP.Presentation.Customers;

namespace Kanc.MVP.Presentation.Order
{
    public interface IEditOrderView : IMyBaseView
    {
        int Id { get; set; }
        int Rok { get; set; }
        string Owner { get; set; }
    }
}
