namespace Kanc.MVP.Presentation.Customers
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
