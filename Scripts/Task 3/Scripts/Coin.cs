using UnityEngine;

public class Coin : MonoBehaviour
{
    public int _value;

    public void Initialize(int value)
    {
        _value = value;
        Debug.Log("Initialized coin with value: " + _value);
    }
    public void MoveTo(Vector3 spawnPosition) => transform.position = spawnPosition;
}