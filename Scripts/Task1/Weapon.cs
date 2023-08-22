using UnityEngine;

public abstract class Weapon
{
    protected int Bullets;
    protected int MaxBulletsInMagazine;

    public void Reload()
    {
        Bullets = MaxBulletsInMagazine;
    }
    public virtual void Shoot()
    {

        if (Bullets > 0)
        {
            Debug.Log("PEWPEW");
            Bullets--;
        }
        else
        {
            Debug.Log("Press R to reload");
        }

    }
}
