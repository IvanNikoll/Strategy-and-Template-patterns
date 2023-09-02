using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private int _spawnDelay;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private CoinFactory _coinFactory;

    private Coroutine _spawnCoroutine;

    public void StartSpawn()
    {
        StopSpawn();

        _spawnCoroutine = StartCoroutine(SpawnCoroutine());
    }

    public void StopSpawn()
    {
        if(_spawnCoroutine != null)
        {
            StopCoroutine(_spawnCoroutine);
        }
    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            GetRandomCoin();
            yield return new WaitForSeconds(_spawnDelay);
        }
    }

    private void GetRandomCoin()
    {
        Coin coin = _coinFactory.Get((CoinTypes)UnityEngine.Random.Range(0, Enum.GetValues(typeof(CoinTypes)).Length));
        SetCoinPosition(coin);
    }

    private void SetCoinPosition(Coin coin)
    {
        if(_spawnPoints.Count> 0)
        {
            Transform spawnPoint = _spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)];
            coin.MoveTo(spawnPoint.position);
            _spawnPoints.Remove(spawnPoint);
        }
        else
        {
            throw new ArgumentException(nameof(_spawnPoints));
        }
    }
}
