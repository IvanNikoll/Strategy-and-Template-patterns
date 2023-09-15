using UnityEngine;

public class KeyboardInput : MovementHandler, IMover
{
    private CharacterController _characterController;
    private const string UsingKeyborad = "Keyboard Input";
    private const string _verticalInput = "Vertical";
    private const string _horizontalInput = "Horizontal";
    private Vector3 _movementVector;
    public KeyboardInput(Transform transform, CharacterController characterController)
    {
        Transform = transform;
        _characterController = characterController;
    }

    public void StartMove()
    {
        Debug.Log(UsingKeyborad);
    }

    public void Update(float deltaTime)
    {
        GetMovementVector();
        MoveCharacter(_movementVector);
    }

    private void GetMovementVector()
    {
        Vector2 axis = new Vector2(Input.GetAxis(_horizontalInput), Input.GetAxis(_verticalInput));
        if (axis.sqrMagnitude > 0.001f)
        {
            _movementVector = Camera.main.transform.TransformDirection(axis);
            _movementVector.y = 0;
            _movementVector.Normalize();
            Transform.forward = _movementVector;
            _movementVector += Physics.gravity;
        }
    }

    private void MoveCharacter(Vector3 movementVector)
    {
        _characterController.Move(movementVector * (MovementSpeed * (IsRunning ? RunningMultiplier : 1f) * Time.deltaTime));
    }
}