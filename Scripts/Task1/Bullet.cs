using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed;
    private Vector3 _shootVector;

    public Bullet()
    {
        _speed = 0.1f;
        _shootVector = new Vector3(0,0,_speed);
    }

    private void Update()
    {
        Fly();
    }
    private void Fly()
    {
        gameObject.transform.Translate(_shootVector);
    }


}
