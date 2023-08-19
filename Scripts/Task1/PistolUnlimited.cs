using UnityEngine;

public class PistolUnlimited : IShooter
{
    public PistolUnlimited()
    {

    }
    
    public void Reload()
    {
        
    }

    public void Shoot()
    {
        Debug.Log("PEWPEW");
    }

    public void Update(float deltaTime)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();    
        }
        
    }
}
