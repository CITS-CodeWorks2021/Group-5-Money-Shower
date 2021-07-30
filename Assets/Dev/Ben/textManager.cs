using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textManager : MonoBehaviour
{
    public sharedNumber money;
    string displayMon;
    public Text awayMon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayMon = money.Value.ToString("c");
        awayMon.GetComponent<Text>().text = displayMon;
    }
}
