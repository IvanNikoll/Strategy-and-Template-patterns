using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CoinFactory", menuName = "Factories/CoinFactory")]
public class CoinFactory : ScriptableObject
{
    [SerializeField] private CoinConfig _smallCoin, _mediumCoin, _largeCoin;

    public Coin Get(CoinTypes coinType)
    {
        CoinConfig coinConfig = GetCoinConfig(coinType);
        Coin instanse = Instantiate(coinConfig.Prefab);
        instanse.Initialize(coinConfig.Value);
        return instanse;
    }

    private CoinConfig GetCoinConfig(CoinTypes coinType)
    {
        switch (coinType)
        {
            case CoinTypes.SmallCoin:
                return _smallCoin;
            case CoinTypes.MediumCoin:
                return _mediumCoin;
            case CoinTypes.LargeCoin:
                return _largeCoin;
            default:
                throw new ArgumentException(nameof(coinType));
        }
    }
}
