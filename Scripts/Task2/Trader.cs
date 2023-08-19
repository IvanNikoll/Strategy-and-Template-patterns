using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trader : MonoBehaviour
{
    protected string RefuseTrading = "NO, your reputation is too bad to deal with you";
    protected int MinKarma;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Looking at player");
        if(other.TryGetComponent(out ICustomer customer))
        {
            ShowMessage(customer);
        }
        Debug.Log("GoodBye");
    }

    protected abstract void ShowMessage(ICustomer customer);
    
}
