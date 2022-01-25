using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject frontDoor;
    public GameObject backDoor;
    public GameObject leftDoor;
    public GameObject rightDoor;
    public GameObject[] objects;
    //public LvlGeneration lvlGeneration;


    




    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);

        //lvlGeneration = FindObjectOfType<LvlGeneration>();


        //lvlGeneration = FindObjectOfType <LvlGeneration> GetComponents 

        //lvlGeneration = find GetComponents<LvlGeneration>;
        //lvlGeneration door;

        DeActiveWall();
    }


    void Update()
    {
        
    }

    public void DeActiveWall()
    {


        if (LvlGeneration.door == 1)
        {
            frontDoor.SetActive(true);
        }
        else
        {
            frontDoor.SetActive(false);
        }
    }
}
