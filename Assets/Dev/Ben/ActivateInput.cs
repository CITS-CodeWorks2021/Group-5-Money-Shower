using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateInput : MonoBehaviour
{
    public GameObject bank;
    
    public void activate()
    {
        bank.SetActive(true);
    }
}
