public interface ICustomer
{
    string Message { get;}
    int PlayerKarma { get; }

    void ShowMessage(string message);
}
