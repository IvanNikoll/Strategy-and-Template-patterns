using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon: MonoBehaviour
{
    public int MaxMagazineCapacity;
    public int Bullets;

    public Weapon(int maxMagazineCapacity, int bullets)
    {
        MaxMagazineCapacity = maxMagazineCapacity;
        Bullets = bullets;
    }

    public void Shoot()
    {

    }
}
