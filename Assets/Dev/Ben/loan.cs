using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loan : MonoBehaviour
{
    public sharedNumber loanAmount;
    public float loanInterest = .06f;
    float calcInterest = 1;
    public float showTimer = 5;
    float timer;
    public Text loanText;
    public GameObject loanScreen;
    // Start is called before the first frame update
    void Start()
    {
        loanScreen.SetActive(false);
        loanAmount.Value = 0;
        timer = showTimer;
        calcInterest += loanInterest;
    }

    // Update is called once per frame
    void Update()
    {
        if (loanAmount.Value > 0.01f)
        {
            timer -= Time.deltaTime;
        }
        if(timer <= 0)
        {
            loanAmount.Value *= calcInterest;
            timer = showTimer;
        }
        loanText.GetComponent<Text>().text = "Loan Amount = " + loanAmount.Value.ToString("c");
    }

    public void turnOff()
    {
        loanScreen.SetActive(false);
    }
}
