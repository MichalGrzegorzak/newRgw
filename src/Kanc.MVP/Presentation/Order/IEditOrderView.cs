using System.Collections.Generic;
using Kanc.MVP.Domain;
using Kanc.MVP.Presentation.Customers;

namespace Kanc.MVP.Presentation.Client
{
    public interface IEditOrderView : IMyBaseView
    {
        int Id { get; set; }
        string Desc { get; set; }
        string Owner { get; set; }
    }
}
