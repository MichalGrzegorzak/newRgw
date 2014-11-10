namespace Kanc.MVP.Presentation.Customers
{
    public interface IBaseEditCustomersView
    {
        int Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        string Message { get; set; }
    }

    public interface IEditCustomersView : IBaseEditCustomersView
    {
        
    }

    public interface INewCustomersView : IBaseEditCustomersView
    {
        //string Name { get; set; }
        //string Message { get; set; }
    }
}
