using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public sharedNumber money;
    public float timer = 5;
    int eventSelector;
    public float displayMon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            displayMon = money.Value;
            Debug.Log(timer + "... Start cycle");
            eventSelector = Random.Range(1, 6);
            if(eventSelector == 1)
            {
                money.Value -= 500;
                Debug.Log(money + "... 1");
            }else if(eventSelector == 2)
            {
                money.Value -= 200;
                Debug.Log(money + "... 2");
            }else if(eventSelector == 3)
            {
                money.Value -= money.Value;
                Debug.Log(money + "... 3");
            }else if(eventSelector == 4)
            {
                money.Value += 500;
                Debug.Log(money + "... 4");
            }else if(eventSelector == 5)
            {
                money.Value += 1000;
                Debug.Log(money + "... 5");
            }
            timer = 5;
            Debug.Log(timer + "... end cycle");
        }
        displayMon = money.Value;
    }
}
