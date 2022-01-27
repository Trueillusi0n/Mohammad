using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    int size = 10;
    GameObject[] tiles = new GameObject[10];

    private void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            tiles[i] = GameObject.Instantiate(Resources.Load("Room")) as GameObject;

            tiles[i].transform.position = new Vector3(i * 0.32f, 0, 0);
        }
    }

}
