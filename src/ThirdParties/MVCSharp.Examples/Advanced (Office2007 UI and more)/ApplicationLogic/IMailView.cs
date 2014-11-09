namespace Customization.ApplicationLogic
{
    public interface IMailView
    {
        string RecipientAddress { get; }

        string SenderAddress { get; set; }
    }
}
