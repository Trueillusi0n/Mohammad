using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGeneration : MonoBehaviour
{
    public GameObject[] rooms;

    private int directon;
    public float moveAmount;
    public float moveAmountZ;
    public int maxRoom;
    //public bool stopGenerating;
    //public GameObject TheWallDeActive;
    //public bool door;
    public static int door;

    private float timer;
    private float totalTimer;
    public float startTimer = 0.25f;

    void Start()
    {
        directon = Random.Range(1, 4);

    }

    void Update()
    {
        
        if (timer <= 0 && totalTimer < maxRoom/4)
        {
            Move();
            timer = startTimer;
        }
        else
        {
            timer -= Time.deltaTime;
            totalTimer += Time.deltaTime;
        }

    
    }

    private void Move()
    {
        if (directon == 1)
        {
            door = 1;
            Vector3 newPos = new Vector3(transform.position.x + moveAmount, transform.position.y, transform.position.z);
            transform.position = newPos;

            directon = Random.Range(2, 4);
            if (directon == 2)
            {
                directon = 1;
            }
        }

        else if (directon == 2)
        {
            door = 2;
            Vector3 newPos = new Vector3(transform.position.x - moveAmount, transform.position.y, transform.position.z);
            transform.position = newPos;

            directon = Random.Range(2, 4);
        }

        else if (directon == 3)
        {
            door = 3;
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y , transform.position.z - moveAmountZ);
            transform.position = newPos;

            directon = Random.Range(1, 4);
        }


        Instantiate(rooms[0], transform.position, Quaternion.identity);
    }

    //public void DeActiveWall()
    //{
    //    TheWallDeActive.SetActive(false);
    //}
}
