using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorScript : MonoBehaviour
{
    Color purple = new Color(247f, 0f, 255f,1f);
    Color orange = new Color(255f,130f, 0f,1f);


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = purple;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Renderer>().material.color = orange;
        }
    }
}
