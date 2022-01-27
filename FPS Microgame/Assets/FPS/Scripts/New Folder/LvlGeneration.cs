using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGeneration : MonoBehaviour
{
    //NewBehaviourScript1
    public GameObject[] rooms;

    public static int directon;
    public float moveAmount;
    public float moveAmountZ;
    public int maxRoom;
    //public bool stopGenerating;
    //public GameObject TheWallDeActive;
    //public bool door;
    public static int door;
    public static int nextDoor;
    public static int nextDoor1;
    public static int nextDoor2;
    public static int index;
    public static string currentRoom;
    public static string thisRoom;
    public static int wtf;


    private float timer;
    private float totalTimer;
    public float startTimer = 0.5f;

    void Start()
    {
        directon = Random.Range(1, 4);

    }

    void Update()
    {

        if (timer <= 0 && totalTimer < maxRoom / 4)
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
            wtf = 1;
            door = 1;
            Vector3 newPos = new Vector3(transform.position.x + moveAmount, transform.position.y, transform.position.z);
            transform.position = newPos;
            thisRoom = currentRoom;

            directon = Random.Range(2, 4);
            if (directon == 2)
            {
                directon = 1;
            }
        }

        else if (directon == 2)
        {
            wtf = 2;
            door = 2;
            Vector3 newPos = new Vector3(transform.position.x - moveAmount, transform.position.y, transform.position.z);
            transform.position = newPos;

            thisRoom = currentRoom;
            directon = Random.Range(2, 4);
        }

        else if (directon == 3)
        {
            wtf = 3;
            door = 3;
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - moveAmountZ);
            transform.position = newPos;

            thisRoom = currentRoom;
            directon = Random.Range(1, 4);
        }

        //float prev = float( rooms[index - 1]);

        Instantiate(rooms[0], transform.position, Quaternion.identity);
    }

    //public void DeActiveWall()
    //{
    //    TheWallDeActive.SetActive(false);
    //}
}