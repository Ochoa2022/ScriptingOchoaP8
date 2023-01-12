using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarandFun : MonoBehaviour
{
    int myInt = 5;
    
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
            
    }

    
    int MultiplyByTwo (int num)
    {
        int result;
        result = num * 2;
        return result;
    }
}
