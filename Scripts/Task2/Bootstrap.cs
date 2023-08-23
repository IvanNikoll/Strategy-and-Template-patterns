using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] int PlayerKarma;
    [SerializeField] Character Character;

    private void Start()
    {
        Character.Initialize(PlayerKarma);
    }
}
