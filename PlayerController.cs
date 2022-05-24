using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float color = 255;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        
        Debug.Log("Entered");
        if(other.gameObject.tag == "Enemy")
        {
            color -= 63.75f;
            if(color == 0)
            {
                SceneManager.LoadScene("Menu");
            }
            
        }
        gameObject.GetComponent<Renderer>().material.color = new Color(color, color, color);
        Destroy(other.gameObject);
        
    }
}
