using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoyalTrader : Trader
{
    private string _message = "Let's trade";

    public LoyalTrader()
    {
        MinKarma = 0;
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
