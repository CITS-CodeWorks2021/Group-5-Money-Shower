using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textBox;

        public void ClickTheButton() {
        textBox.SetActive(true);
    }

}
