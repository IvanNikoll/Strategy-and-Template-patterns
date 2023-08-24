using System.Collections.Generic;
using UnityEngine;

public class UniColorMode : Counter
{
    private List<Ball> _incomingList;

    public override void SetEnemiesList(List<Ball> enemiesList)
    {
        EnemiesList = new List<Ball>();
        _incomingList = enemiesList ?? new List<Ball>();

        foreach(Ball ball in _incomingList)
        {
            if(ball.gameObject.TryGetComponent(out GreenBall greenBall))
            {
                EnemiesList.Add(greenBall);
            }
        }

        EnemiesQuantity = EnemiesList.Count;
    }

    public override void OnEnemySpotted(Ball target)
    {

        if(target.gameObject.TryGetComponent(out GreenBall greenBall))
        {
            OnEnemyDied();
            EnemiesQuantity--;
            Debug.Log(EnemiesQuantity);
        }
        
    }
}
