using UnityEngine;

public class MachineGun : Weapon, IShootable
{
    private const int _bulletsPerShoot = 3;

    public MachineGun(int bullets, int maxBulletsInMagazine)
    {
        Bullets = bullets;
        MaxBulletsInMagazine = maxBulletsInMagazine;
    }

    public override void Shoot()
    {

        if (Bullets > 0)
        {
            for (int i = 0; i < _bulletsPerShoot; i++)
            {
                Debug.Log("PEWPEW");
                Bullets--;
            }
        }

        base.Shoot();
    }
}
