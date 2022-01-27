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
        //int rand = Random.Range(0, objects.Length);
        //Instantiate(objects[rand], transform.position, Quaternion.identity);

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
        // 1 = rightDorr
        // 2 = leftDoor
        // 3 = fronDoor

        if (LvlGeneration.directon == 1)
        {
            rightDoor.SetActive(false);

            if (LvlGeneration.wtf == 1)
            {
                leftDoor.SetActive(false);
            }
            if (LvlGeneration.wtf == 3)
            {
                backDoor.SetActive(false);
            }
           



        }


        if (LvlGeneration.directon == 2)
        {
            leftDoor.SetActive(false);

            if (LvlGeneration.wtf == 2)
            {
                rightDoor.SetActive(false);
            }

            if (LvlGeneration.wtf == 3)
            {
                backDoor.SetActive(false);
            }
        }


        if (LvlGeneration.directon == 3)
        {
            frontDoor.SetActive(false);

            if (LvlGeneration.wtf == 3)
            {
                backDoor.SetActive(false);
                if (LvlGeneration.directon == 3)
                {
                  
                    leftDoor.SetActive(false);

                }

            }



            if (LvlGeneration.directon == 2)
            {
                backDoor.SetActive(false);
            }


        }


    }
}
