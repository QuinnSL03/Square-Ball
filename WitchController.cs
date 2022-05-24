using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Minion;
    public int MoveSpeed = 1;
    int MaxDist = 10;
    int MinDist = 1;
    int direction = 0;
    int count = 0;
 
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");

        // decides which direction the enemy would lean towards
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        transform.LookAt(Player.transform);
 
         if (Vector3.Distance(transform.position, Player.transform.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;

 
 
 
             if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
             {
                 //Here Call any function U want Like Shoot at here or something
             }
 
         }
        /** spawns minions every couple of seconds
        if (count % 800 == 0 && Vector3.Distance(transform.position, Player.transform.position) < 15)
        {
            spawnMinions();
        }
        */
    }
    private void spawnMinions()
    {
        
        for(int i = 0; i < 4; i++)
        {
            GameObject spawnPoint = transform.GetChild(i).gameObject;
            Instantiate(Minion, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z), Quaternion.identity);
        }
        
    }
    private void OnMouseDown() {
        spawnMinions();
        Destroy(gameObject);
    }
}
