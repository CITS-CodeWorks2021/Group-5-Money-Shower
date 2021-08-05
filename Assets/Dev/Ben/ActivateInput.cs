using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateInput : MonoBehaviour
{
    bool pressed = false;
    public GameObject bank;
    
    public void activate()
    {
        if (!pressed)
        {
            bank.SetActive(true);
            pressed = true;
        }else if (pressed)
        {
            bank.SetActive(false);
            pressed = false;
        }
    }
}
