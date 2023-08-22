using UnityEngine;

public class Shooter : MonoBehaviour
{
    private IShootable _shootable;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _shootable.Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _shootable.Reload();
        }

    }

    public void SetShooter(IShootable shooter)
    {
        _shootable = shooter;
    }
}
