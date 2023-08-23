using UnityEngine;

public class UnFriendlyTrader : Trader
{
    private const string _confirmTradingMessage = "OK, but don't tell anyone";

    public UnFriendlyTrader()
    {
        MinKarmaToTrade = 10;
    }

    protected override void Trade(Collider other, IBuyer customer)
    {

        if (customer.PlayerKarma >= MinKarmaToTrade)
        {
            Message = _confirmTradingMessage;
        }

        else Message = RefuseTradingMessage;
        SendMessage(Message, customer);
    }
}

