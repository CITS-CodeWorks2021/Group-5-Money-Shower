using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public sharedNumber mainMoney;
    public float timer = 5;
    int eventSelector;
    int gainLose, deltaMoney;
    public float displayMon;
    public Text EOS;
    public GameObject EOSPopUp;
    void Start()
    {
        EOSPopUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            displayMon = mainMoney.Value;
            Debug.Log(timer + "... Start cycle");
            eventSelector = Random.Range(1, 7);
            if(eventSelector == 1)
            {
                mainMoney.Value -= 500;
                deltaMoney = 500;
                gainLose = 0;
                Debug.Log(mainMoney + "... 1");
            }else if(eventSelector == 2)
            {
                mainMoney.Value -= 200;
                deltaMoney = 200;
                gainLose = 0;
                Debug.Log(mainMoney + "... 2");
            }else if(eventSelector == 3)
            {
                deltaMoney = (int)mainMoney.Value / 2;
                mainMoney.Value -= mainMoney.Value / 2;
                
                gainLose = 0;
                Debug.Log(mainMoney + "... 3");
            }else if(eventSelector == 4)
            {
                mainMoney.Value += 500;
                deltaMoney = 500;
                gainLose = 1;
                Debug.Log(mainMoney + "... 4");
            }else if(eventSelector == 5)
            {
                mainMoney.Value += 1000;
                deltaMoney = 1000;
                gainLose = 1;
                Debug.Log(mainMoney + "... 5");
            }else if(eventSelector == 6)
            {
                deltaMoney = (int)(mainMoney.Value);
                mainMoney.Value *= 2;
                gainLose = 1;
                Debug.Log(mainMoney + "... 6");
            }
            if (gainLose == 1)
            {
                EOS.GetComponent<Text>().text = "Congratulations, you got an extra " + deltaMoney.ToString("c") + "! Spend it well!";
            } else if (gainLose == 0)
            {
                EOS.GetComponent<Text>().text = "Uh oh! Looks like you lost " + deltaMoney.ToString("c") + "!";
            }
            EOSPopUp.SetActive(true);
            timer = 5;
            Debug.Log(timer + "... end cycle");
        }
        displayMon = mainMoney.Value;
    }

    public void offButton()
    {
        EOSPopUp.SetActive(false);
    }
}
