
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Manager3 : MonoBehaviour
{

    public bool condition1 { get; set; }
    public bool condition2 { get; set; }


    // Update is called once per frame
    void Update()
    {
        if (condition2 == true)
        {
            Debug.Log("You won!!!");
            SceneManager.LoadScene("ReagenzglaeserRewardScene");
        }


    }
}