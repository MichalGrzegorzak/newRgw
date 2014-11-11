namespace Kanc.MVP.Presentation.Customers
{
    public interface IBaseEditCustomersView
    {
        int Id { get; set; }
        string NazwiskoPl { get; set; }
        int Age { get; set; }
        string Message { get; set; }

        bool IsNew { get; }
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
