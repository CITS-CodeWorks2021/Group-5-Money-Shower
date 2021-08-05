using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class withdraw : MonoBehaviour
{
    // Start is called before the first frame update
    public float deposit;
    public sharedNumber mainMoney;
    public sharedNumber money;
    // Start is called before the first frame update
    void Start()
    {
        money.OnValueChanged.AddListener(HandleValueChanged);
    }

    private void HandleValueChanged(float arg0)
    {
        Debug.Log(arg0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void depositAmount(string amount)
    {
        if (float.TryParse(amount, out deposit))
        {
            mainMoney.Value += deposit;
            money.Value -= deposit;
            GetComponent<InputField>().text = "";
        }
        else
        {
            GetComponent<InputField>().text = deposit.ToString();
        }
    }
}
