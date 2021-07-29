using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputListener : MonoBehaviour
{
    public GameObject inputText;
    Text takenText;
    public GameObject field;
    // Start is called before the first frame update
    private void assign()
    {
        takenText = inputText.GetComponent<Text>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
