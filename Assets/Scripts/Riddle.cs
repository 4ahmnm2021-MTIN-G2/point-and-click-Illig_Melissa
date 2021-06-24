
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Riddle : MonoBehaviour
{

    public bool condition1 { get; set; }
    public bool condition2 { get; set; }
    public bool condition3 { get; set; }
    public bool condition4 { get; set; }


    // Update is called once per frame
    void Update()
    {
        if (condition4 == true)
        {
            Debug.Log("You solved the Riddle!!!");
            SceneManager.LoadScene("MikroskopRewardScene");
        }


    }
}