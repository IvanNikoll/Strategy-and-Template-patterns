using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : IShooter
{
    private int _bullets;
    private int _maxBulletsInMagazine;
    public Pistol(int bullets, int maxBulletsInMagazine)
    {
        _bullets = bullets;
        _maxBulletsInMagazine = maxBulletsInMagazine;
    }

    public void Reload()
    {
        _bullets = _maxBulletsInMagazine;
    }

    public void Shoot()
    {
        Debug.Log("PEWPEW");
        _bullets--;
    }

    public void Update(float deltaTime)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_bullets > 0)
            {
                Shoot();
            }
            else
            {
                Debug.Log("Press R to reload");
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            Reload();
        }

    }
}
