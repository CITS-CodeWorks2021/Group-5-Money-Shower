using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu(fileName ="number", menuName ="Data")]
public class sharedNumber : ScriptableObject
{
    private float number;
    public UnityEvent<float> OnValueChanged = new UnityEvent<float>();
    public float Value
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
            OnValueChanged.Invoke(number);
        }
    }
}
