using UnityEngine;

public class LevelSwitcher : MonoBehaviour
{
    [SerializeField] EventDetector _eventDetector;

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Alpha1))
        {
            _eventDetector.SetCounter(new UniColorMode());
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            _eventDetector.SetCounter(new MultiColorMode());
        } 

    }
}
