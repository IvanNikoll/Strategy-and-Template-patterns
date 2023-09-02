using System;
using UnityEngine;

[Serializable]
public class CoinConfig 
{
    [SerializeField] private Coin _prefab;
    [SerializeField] private int _value;

    public Coin Prefab => _prefab;
    public int Value => _value;
}
