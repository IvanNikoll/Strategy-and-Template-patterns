using UnityEngine;

public abstract class Trader : MonoBehaviour
{
    protected int MinKarmaToTrade;
    protected string Message;
    protected const string RefuseTradingMessage = "NO, your reputation is too bad to deal with you";
    protected const string FruitTradingMessage = "I don't care about your karma, just buy my fruit";
    private const string _confirmTradingMessage = "OK, let's trade";
    private const string _engagingCharacterMessage = "Looking at character";
    private const string _byeMessage = "Goodbye";

    protected virtual void Trade(Collider other, IBuyer customer)
    {

        if (customer.PlayerKarma >= MinKarmaToTrade)
        {
            Message = _confirmTradingMessage;
        }

        else Message = RefuseTradingMessage;
        SendMessage(Message, customer);
    }

    protected void SendMessage(string message, IBuyer customer)
    {
        customer.ShowMessage(message);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(_engagingCharacterMessage);

        if (other.TryGetComponent(out IBuyer customer))
        {
            Trade(other, customer);
        }

        Debug.Log(_byeMessage);
    }
}
