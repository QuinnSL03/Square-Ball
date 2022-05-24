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

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        count++;
        //Wave 1
        if(count % 35 == 0 && count < 500)
        {
            Debug.Log("Spawned");
            Instantiate(enemy1, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
                
        }
        //Wave 2
        if(count > 500 && count < 1000)
        {
            if(count % 70 == 0)
            {
                Debug.Log("Spawned 2");
                Instantiate(enemy2, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % 75 == 30)
            {
                Instantiate(enemy1, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            
        }

        //Wave 3
        if(count > 1000 && count < 2000)
        {
            if(count % 200 == 0)
            {
                Instantiate(enemy2, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % 100 == 50)
            {
                Instantiate(enemy1, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % 200 == 150)
            {
                Instantiate(enemy3, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            
        }

        //Wave 4
        if(count > 2000 && count < 3500)
        {
            if(count % 300 == 0)
            {
                Instantiate(enemy1, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % 300 == 0)
            {
                Instantiate(enemy2, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % 300 == 225)
            {
                Instantiate(enemy3, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            if(count % 300 == 0)
            {
                Instantiate(witch, new Vector3(this.transform.position.x + GetModifier(), 0.5f,  this.transform.position.z + GetModifier()), Quaternion.identity);
            }
            
        }

        if(count > 3500)
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
