using UnityEngine;

public class PistolUnlimited : Weapon, IShootable
{
    public override void Shoot()
    {
        Debug.Log("PEWPEW");
    }
}
