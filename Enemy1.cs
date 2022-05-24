using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy1 : MonoBehaviour
{
    //public GameController gameController;
    public GameObject Player;
    int MoveSpeed = 2;
    int MinDist = 1;
    int direction = 0;
 
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        //gameController = gameController.GetComponent<GameController>();
        
;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
 
         if (Vector3.Distance(transform.position, Player.transform.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
         }

    }

    private void OnMouseDown() {
        //gameController.enemyCountDestroyed++;
        Destroy(gameObject);
        
    }
    /**
    private void OnCollisionEnter(Collision other) {
        GetComponent<Renderer>().material.color = new Color(255, 255, 255); 
        if(other.gameObject.tag == "Player")
        {

            SceneManager.LoadScene("Menu");
        }
        
    }
    */
}
