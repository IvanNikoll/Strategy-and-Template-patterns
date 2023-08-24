using UnityEngine;

public class Player : PlayerController
{
    [SerializeField] private int _score;

    private void Start()
    {
        Counter.EnemyDied += OnEnemySpotted;    
    }

    private void OnEnemySpotted()
    {
        _score++;
    }
}
