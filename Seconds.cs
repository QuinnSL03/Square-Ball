using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seconds : MonoBehaviour
{
    public Text txt;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        txt.GetComponent<UnityEngine.UI.Text>().text =  "" + (int)(count / 50);
        count++;
    }
}
