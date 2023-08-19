using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ICustomer
{
    [SerializeField] int Karma;
   
    public string Message { get; private set; }
    public  int PlayerKarma { get; private set; }
    public Player()
    {
        PlayerKarma = Karma;
    }

    public void ShowMessage(string message)
    {
        Debug.Log(message);
    }
}
