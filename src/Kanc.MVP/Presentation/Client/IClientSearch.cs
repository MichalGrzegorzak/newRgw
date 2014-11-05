namespace Kanc.MVP.Presentation.Client
{
    public interface IClientSearch
    {
        string RecipientAddress { get; }

        string SenderAddress { get; set; }
    }
}
