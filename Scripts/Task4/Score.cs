using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int Value => _enemyVisitor.Value;
    private EnemyVisitor _enemyVisitor;
    private IEnemyDeathNotifier _deathNotifier;

    public Score(IEnemyDeathNotifier deathNotifier)
    {
        _deathNotifier= deathNotifier;
        _enemyVisitor = new EnemyVisitor();
        _deathNotifier.Notified += OnEnemyKilled;
    }

    private void OnEnemyKilled(Enemy enemy)
    {
        _deathNotifier.Notified -= OnEnemyKilled;
        enemy.Accept(_enemyVisitor);
        Debug.Log(Value);
    }
    private class EnemyVisitor : IEnemyVisitor
    {
        public int Value { get; private set; }

        public void Visit(Orc orc)
        {
            Value += 20;
        }

        public void Visit(Human human)
        {
            Value += 5;
        }

        public void Visit(Elf elf)
        {
            Value += 10;
        }
    }
}
