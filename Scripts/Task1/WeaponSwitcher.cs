using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] Shooter _weapon;

    private void Awake()
    {
        _weapon.SetShooter(new Pistol(15,15));
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _weapon.SetShooter(new Pistol(15, 15));
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _weapon.SetShooter(new PistolUnlimited());
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _weapon.SetShooter(new MachineGun(12, 12));
        }

    }
}
