public interface IBuyer
{
    string Message { get;}
    int PlayerKarma { get; protected set; }

    void Initialize(int playerKarma);

    void ShowMessage(string message);

}
