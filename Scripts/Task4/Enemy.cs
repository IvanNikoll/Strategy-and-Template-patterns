using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy: MonoBehaviour
{
    public event Action<Enemy> Died;
    public void MoveToPosition(Vector3 position) => transform.position = position;

    public abstract void Accept(IEnemyVisitor visitor);
    
    public void Die()
    {
        Died?.Invoke(this);
        Destroy(gameObject);
    }
}
