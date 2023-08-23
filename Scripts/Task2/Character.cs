using UnityEngine;

public class Character : MonoBehaviour, IBuyer
{
    private int _playerKarma;

    public string Message { get;}
    int IBuyer.PlayerKarma { get { return _playerKarma; } set { _playerKarma = value; } }

    public void Initialize(int playerKarma)
    {
       _playerKarma = playerKarma;
    }

    public void ShowMessage(string message)
    {
        Debug.Log(message);
    }
}
