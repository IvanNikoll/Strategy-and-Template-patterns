using UnityEngine;
using UnityEngine.AI;

public class PlayerChecker : MonoBehaviour
{
    [SerializeField] private PlayerMove _player;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private NavMeshAgent _navMeshAgent;
    [SerializeField] private CharacterController Controller;
    private Transform _transform;
    private const string _verticalInput = "Vertical";
    private const string _horizontalInput = "Horizontal";
    private bool _isMouseActive;
    private bool _isKeyboardActive;

    private void Start()
    {
        _transform = transform;
    }
    void Update()
    {
        CheckKeyboardKeys();
        CheckMouseActivity();
    }

    private void CheckMouseActivity()
    {
        if (!_isMouseActive)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;
            if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hitPoint))
            {
                _player.SetMover(new MouseInput(_transform, _navMeshAgent));
                _isMouseActive = true;
                _isKeyboardActive = false;
            }
        }
    }

    private void CheckKeyboardKeys()
    {
        if (!_isKeyboardActive)
        {
            if ((Input.GetAxis(_verticalInput) != 0 || Input.GetAxis(_horizontalInput) != 0))
            {
                _player.SetMover(new KeyboardInput(_transform, Controller));
                _isKeyboardActive = true;
                _isMouseActive = false;
            }
        }    
    }
}