using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

public Transform thisTransform;
public Vector3 mousePos;
public Vector3 mouseCameraPos;
public Vector3 playerPos;
public float speed = 0.1f;


    void Start() 
    {
      playerPos = thisTransform.position;
    }

    void Update()
    {
       if (Input.GetMouseButton(0))
        {
             mousePos = Input.mousePosition;
             mouseCameraPos = Camera.main.ScreenToWorldPoint(mousePos);
             playerPos = new Vector3(mouseCameraPos.x, mouseCameraPos.y, thisTransform.position.z);
        } 

        thisTransform.position = Vector3.MoveTowards(thisTransform.position, playerPos, speed);
    }
}
