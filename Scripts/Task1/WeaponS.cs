using UnityEngine;

public class WeaponS : MonoBehaviour, IShootable
{
    private int _bullets;
    private int _maxBulletsInMagazine;

    private IShooter _shooter;

    public int Bullets => _bullets;

    public int MaxBulletsInMagazine => _maxBulletsInMagazine;

    private void Update() => _shooter.Update(Time.deltaTime);

    public void SetShooter(IShooter shooter)
    {
        _shooter = shooter;
    }

}
