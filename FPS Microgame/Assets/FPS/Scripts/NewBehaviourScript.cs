using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int antalRoom = 1;
    public GameObject[] myArray;
    public GameObject arr;
    public int moveAmount = 30;
    public static int directon;
    public int moveAmountZ = 20;


    void Start()
    {
        directon = Random.Range(1, 3);
        myArray = new GameObject[antalRoom];
        for (int i = 0; i < antalRoom; i++)
        {

            if (directon == 1)
            {
                Vector3 newPos = new Vector3(transform.position.x + moveAmount, transform.position.y, transform.position.z);
                transform.position = newPos;

                directon = Random.Range(2, 4);
                if (directon == 2)
                {
                    directon = 1;
                }

            }


            if (directon == 2)
            {
                Vector3 newPos = new Vector3(transform.position.x - moveAmount, transform.position.y, transform.position.z);
                transform.position = newPos;

                directon = Random.Range(2, 4);
            }

            if (directon == 3)
            {
                Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - moveAmountZ);
                transform.position = newPos;

                directon = Random.Range(1, 4);
            }

            GameObject go = Instantiate(arr, new Vector3((float)i, 1, 0), Quaternion.identity) as GameObject;
            go.transform.localPosition = transform.position;
            myArray[i] = go;




            //GameObject go = Instantiate(arr, new Vector3(transform.position.x, transform.position.y+20,transform.position.z+20), Quaternion.identity) as GameObject;
            ////go.transform.localScale = Vector3.one;

            ////GameObject go = Instantiate(arr, new Vector3(transform.position.x + moveAmount, transform.position.y,
            ////    transform.position.z));

            ////go.transform.localPosition = new Vector3(transform.position.x + moveAmount, transform.position.y,
            ////    transform.position.z);
            //go.transform.localPosition = new Vector3(transform.position.x + moveAmount, transform.position.y, transform.position.z);
            //myArray[i] = go;

            ////Vector3 newPos = new Vector3(transform.position.x + moveAmount, transform.position.y, transform.position.z);
            ////transform.position = newPos;
        }

    }


    void Update()
        {

            //if (directon == 1)
            //{

            //    directon = Random.Range(2, 4);
            //    if (directon == 2)
            //    {
            //        directon = 1;
            //    }

            //}


            //Instantiate(myArray[i], transform.position, Quaternion.identity);

        }

    
}
