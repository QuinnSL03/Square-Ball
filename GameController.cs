using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Transform player;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject witch;
    public static float difficulty;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(difficulty);
        
        count++;
        //Wave 1
        if(count % (int)(35 * difficulty) == 0 && count < 500)
        {
            Debug.Log("Spawned");
            Instantiate(enemy1, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
                
        }
        //Wave 2
        if(count > 500 && count < 1000)
        {
            if(count % (int)(70 * difficulty) == 0)
            {
                Debug.Log("Spawned 2");
                Instantiate(enemy2, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % (int)(75 * difficulty) == 30)
            {
                Instantiate(enemy1, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            
        }

        //Wave 3
        if(count > 1000 && count < 2000)
        {
            if(count % (int)(200 * difficulty) == 0)
            {
                Instantiate(enemy2, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % (int)(100 * difficulty) == 50)
            {
                Instantiate(enemy1, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % (int)(200 * difficulty) == 150)
            {
                Instantiate(enemy3, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            
        }

        //Wave 4
        if(count > 2000 && count < 5500)
        {
            if(count % (int)(300 * difficulty) == 0)
            {
                Instantiate(enemy1, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % (int)(300 * difficulty) == 0)
            {
                Instantiate(enemy2, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % (int)(300 * difficulty) == 225)
            {
                Instantiate(enemy3, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % (int)(300 * difficulty) == 0)
            {
                Instantiate(witch, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            
        }

        if(count > 5700)
        {
            SceneManager.LoadScene("WinScreen");
        }
        
        
        
    }
    float GetModifier()
    {
        float modifier = Random.Range(10f, 25f);
        if (Random.Range(0, 2) > 0)
            return -modifier;
        else
            return modifier;
    }
    

}
