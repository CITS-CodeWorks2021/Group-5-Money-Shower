using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textManager : MonoBehaviour
{
    public sharedNumber money;
    public sharedNumber mainMoney;
    string displayAwayMon;
    public Text awayMon;
    string displayMainMon;
    public Text mainMon;
    // Start is called before the first frame update
    void Start()
    {
        mainMoney.Value = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        displayMainMon = mainMoney.Value.ToString("c");
        mainMon.GetComponent<Text>().text = displayMainMon;
        displayAwayMon = money.Value.ToString("c");
        awayMon.GetComponent<Text>().text = displayAwayMon;
    }
}
