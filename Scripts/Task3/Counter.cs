using System;
using System.Collections.Generic;
using UnityEngine;

public class Counter: ICounter
{
    public static event Action EnemyDied;
    protected List<Ball> EnemiesList;
    protected int EnemiesQuantity;
    private const string _gameFinishText = "Game finished";
    private bool isRoundFinished;

    public virtual void SetEnemiesList(List<Ball> enemiesList)
    {
        EnemiesList = enemiesList ?? new List<Ball>();
        EnemiesQuantity = EnemiesList.Count;
    }

    public void Update(float deltaTime)
    {

        if (EnemiesQuantity == 0 && isRoundFinished == false)
        {
            isRoundFinished = true;
            FinishTheRound();
        }

    }

    public static void OnEnemyDied()
    {
        EnemyDied?.Invoke();
    }

    protected void FinishTheRound()
    {
        Debug.Log(_gameFinishText);
    }

    public virtual void OnEnemySpotted(Ball target)
    {
        OnEnemyDied();
        EnemiesQuantity--;
    }
}
