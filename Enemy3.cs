using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public GameObject Player;
    int MoveSpeed = 2;
    int MaxDist = 10;
    int MinDist = 1;
    int direction = 0;
    int count = 0;

 
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");

        // decides which direction the enemy would lean towards
        if(Random.Range(0f, 2f) > 1f)
        {
            direction = 1;
        }
        else
        direction = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        transform.LookAt(Player.transform);
 
         if (Vector3.Distance(transform.position, Player.transform.position) >= MinDist)
         {
            if(count % 125 == 0)
            {
                if(direction == 1)
                {
                    direction = 0;
                }
                else
                {
                    direction = 1;
                }
            }
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            if(direction < 1)
            {
                transform.position -= transform.right * -.06f;
            }
            else
            {
                transform.position -= transform.right * .06f;
            }
 
 
 
             if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
             {
                 //Here Call any function U want Like Shoot at here or something
             }
 
         }
    }

    private void OnMouseDown() {
        Destroy(gameObject);
    }
}
