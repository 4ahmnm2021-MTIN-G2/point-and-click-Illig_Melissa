
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Manager : MonoBehaviour
{

    public bool condition1 { get; set; }
    public bool condition2 { get; set; }
    public bool condition3 { get; set; }



    // Update is called once per frame
    void Update()
    {
        if (condition3 == true)
        {
            Debug.Log("You won!!!");
        }


    }
}