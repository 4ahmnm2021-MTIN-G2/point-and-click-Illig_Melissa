using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
   public float timeRemaining =180;
   public bool timerIsRunning = false;
   public Text timeText;

    private void Start()
     {
      timerIsRunning = true;  
    }

    void Update() 
    {
       if (timerIsRunning) 
       {
           if(timeRemaining > 0)
           {
           timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
           } 
         else 
         {
           Debug.Log("Die Zeit ist vorbei");
           timeRemaining =0;
           timerIsRunning = false;
           SceneManager.LoadScene("LoseScene");
        }
       }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeRemaining/60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }


}
