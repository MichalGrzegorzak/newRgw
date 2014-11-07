using System.Collections.Generic;
using Kanc.MVP.Domain;

namespace Kanc.MVP.Controllers
{
    public interface IBaseEditCustomersView
    {
        string Name { get; set; }
        string Message { get; set; }
    }

    public interface IEditCustomersView : IBaseEditCustomersView
    {
        //string Name { get; set; }
        //string Message { get; set; }
    }

    public interface INewCustomersView : IBaseEditCustomersView
    {
        //string Name { get; set; }
        //string Message { get; set; }
    }
}
