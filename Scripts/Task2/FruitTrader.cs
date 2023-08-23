using UnityEngine;

public class FruitTrader : Trader
{
    protected override void Trade(Collider other, IBuyer customer) => customer.ShowMessage(FruitTradingMessage);
}
