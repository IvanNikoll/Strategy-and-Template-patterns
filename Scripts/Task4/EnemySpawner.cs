using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour, IEnemyDeathNotifier
{
    [SerializeField] private int _spawnDelay;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private EnemyFactory _enemyFactory;

    private List<Enemy> _spawnedEnemies = new List<Enemy>();

    private Coroutine _spawnCoroutine;

    public event Action<Enemy> Notified;

    public void StartSpawn()
    {
        StopSpawn();

        _spawnCoroutine = StartCoroutine(SpawnCoroutine());
    }

    public void StopSpawn()
    {
        if (_spawnCoroutine != null)
        {
            StopCoroutine(_spawnCoroutine);
        }
    }

    public void KillRandomEnemy()
    {
        if(_spawnedEnemies.Count < 0)
        {
            return;
        }
        else
        {
            _spawnedEnemies[UnityEngine.Random.Range(0, _spawnedEnemies.Count)].Die();
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
        Enemy enemy = _enemyFactory.Get((EnemyType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
        SetCoinPosition(enemy);
    }

    private void SetCoinPosition(Enemy enemy)
    {
        Transform spawnPoint = _spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)];
        enemy.MoveToPosition(spawnPoint.position);
        enemy.Died += OnEnemyDied;
        Notified.Invoke(enemy);
        _spawnedEnemies.Add(enemy);
    }

    private void OnEnemyDied(Enemy enemy)
    {
        enemy.Died -= OnEnemyDied;
        _spawnedEnemies.Remove(enemy);

    }
}
