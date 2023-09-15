using UnityEngine;

public class MovementHandler
{
    protected Transform Transform;
    protected float MovementSpeed = 3f;
    protected float RunningMultiplier = 1.5f;
    protected bool IsRunning;

    public virtual void ProcessInput() { }
}