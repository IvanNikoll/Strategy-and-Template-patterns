using Assets.Visitor;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : ScriptableObject
{
    [SerializeField] private Human _humanPrefab;
    [SerializeField] private Ork _orkPrefab;
    [SerializeField] private Elf _elfPrefab;

    public Enemy Get(EnemyType type)
    {
        switch(type)
        {
            case EnemyType.Elf:
                return Instantiate(_elfPrefab);
            case EnemyType.Ork:
                return Instantiate(_orkPrefab);
            case EnemyType.Human:
                return Instantiate(_humanPrefab);
            default : return new ArgumentException(nameof(type));
        }
    }
}
