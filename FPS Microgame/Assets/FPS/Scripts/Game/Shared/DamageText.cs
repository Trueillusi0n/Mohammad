using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageText : MonoBehaviour
{
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Effect() 
    {
        //DamageText.text =
        Instantiate(Text, transform.position, transform.rotation);
    
    }
}
