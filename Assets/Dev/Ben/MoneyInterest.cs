using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyInterest : MonoBehaviour
{
    public sharedNumber money;
    public float interestAmount = .05f;
    float calcInterest;
    public float showTimer = 5;
    float timer;
    public float displayMon;
    // Start is called before the first frame update
    void Start()
    {
        calcInterest = 1 + interestAmount;
        Debug.Log(calcInterest);
        timer = showTimer;
        money.Value = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if(money.Value < 0)
        {
            money.Value = 0;
        }
        displayMon = money.Value;
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Debug.Log("Calculating");
            money.Value *= calcInterest;
            Debug.Log(money);
            timer = showTimer;
        }
        if(money.Value < 0)
        {
            money.Value = 0;
        }
    }
}
