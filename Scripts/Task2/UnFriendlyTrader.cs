using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnFriendlyTrader : Trader
{
    private string _message = "OK, but don't tell anyone";

    public UnFriendlyTrader()
    {
        MinKarma = 10;
    }

    protected override void ShowMessage(ICustomer customer)
    {
        if (customer.PlayerKarma >= MinKarma)
        {
            customer.ShowMessage(_message);
        }
        else customer.ShowMessage(RefuseTrading);
    }
}

