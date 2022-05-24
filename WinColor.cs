using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinColor : MonoBehaviour
{
    float count = 0;
    public float frq; 
    public float min;
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        //myText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        /**
        Why does this not work...
        if(count < min)
        {
            count -= frq;
        }
        else
        {
            count += frq;
        }
        
        myText.color = new Color(255,255-count,255);
        */
        
    }
}
