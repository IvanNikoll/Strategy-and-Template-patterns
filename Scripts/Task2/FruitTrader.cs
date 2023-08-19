using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTrader : Trader
{
    private string _message = "I don't care about your karma, just buy my fruit";
    protected override void ShowMessage(ICustomer customer) => customer.ShowMessage(_message);
        

}
