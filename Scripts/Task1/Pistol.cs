public class Pistol : Weapon, IShootable
{
    
    public Pistol(int bullets, int maxBulletsInMagazine)
    {
        Bullets = bullets;
        MaxBulletsInMagazine = maxBulletsInMagazine;
    }
}
