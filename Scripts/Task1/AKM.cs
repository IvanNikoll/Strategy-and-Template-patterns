using UnityEngine;

public class AKM : IShooter
{
    private int _bullets;
    private int _maxBulletsInMagazine;
    private int _bulletsPerShoot = 3;
    public AKM(int bullets, int maxBulletsInMagazine)
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

        for (int i = 0; i < _bulletsPerShoot; i++)
        {
            Debug.Log("PEWPEW");
            _bullets--;
        }

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
