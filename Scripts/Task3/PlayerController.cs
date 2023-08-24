using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] EventDetector _detector;

    private void FixedUpdate()
    {
        OnMouseClick();   
    }

    private void OnMouseClick()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _detector.OnClick();
        }

    }
}
