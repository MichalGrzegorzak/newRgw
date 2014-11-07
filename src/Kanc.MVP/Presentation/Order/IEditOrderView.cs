using System.Collections.Generic;
using Kanc.MVP.Domain;

namespace Kanc.MVP.Presentation.Client
{
    public interface IEditOrderView
    {
        int Id { get; set; }
        string Desc { get; set; }
        string Owner { get; set; }
        string Message { get; set; }
    }
}
