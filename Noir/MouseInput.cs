using UnityEngine;
using UnityEngine.AI;

public class MouseInput : MovementHandler, IMover
{
    private NavMeshAgent _navMeshAgent;
    private const string UsingMouse = "Mouse Input";
    public MouseInput(Transform transform, NavMeshAgent MeshAgent)
    {
        Transform = transform;
        _navMeshAgent = MeshAgent;
    }

    public void StartMove()
    {
        Debug.Log(UsingMouse);
        _navMeshAgent.enabled = true;
    }

    public void Update(float deltaTime)
    {
        ProcessInput();
    }

    public override void ProcessInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;
            if (Physics.Raycast(ray, out hitPoint))
            {
                _navMeshAgent.SetDestination(hitPoint.point);
                _navMeshAgent.speed = MovementSpeed * (IsRunning ? RunningMultiplier : 1f);
                Transform.rotation = Transform.parent.rotation;
            }
        }
    }
}