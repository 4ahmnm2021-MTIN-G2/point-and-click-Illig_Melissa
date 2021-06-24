
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Riddle2 : MonoBehaviour
{

    public bool condition1 { get; set; }
    public bool condition2 { get; set; }
    public bool condition3 { get; set; }


    // Update is called once per frame
    void Update()
    {
        if (condition3 == true)
        {
            Debug.Log("You solved the riddle");
            SceneManager.LoadScene("SchubladeRewardScene");
        }


    }
}