using System;

namespace Kanc.MVP.Presentation.Customers
{
    public interface IEditCustomersView : IMyBaseView
    {
        string NazwiskoPl { get; set; }
        DateTime? Urodzony { get; set; }
    }

}
