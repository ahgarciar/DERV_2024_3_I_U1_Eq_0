using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_Debug : MonoBehaviour
{
    int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;    
    }

    // Update is called once per frame
    void Update()
    {
     Debug.Log("Hola" + i.ToString());   
     //i++;
    }
}
