using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    
    void Start()
    {
        //this line is there to tell me the x position of the object

        /* This lets me write
            more then one line
        */

        Debug.Log(transform.position.x);


        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }

   
}
