using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityController : MonoBehaviour
{
    public float newGravity;                                // the new gravity

    private float timer;                                    // how long increased gravity will last
    private float oldGravity;                               // value of original gravity, to reset
    private bool increasedGrav;                             // whether or not the gravity is currently increased

    void Start()
    {
        oldGravity = Physics.gravity.y;                     // getting value of normal gravity
        increasedGrav = false;                              // increased gravity starts as off
    }

    void Update()
    {
        if (timer > 0)                                      // if timer is more than 0, it will count down
        {
            timer -= Time.deltaTime;
            //Debug.Log("time left: " + timer);
        }
        else
        {
            timer = 0f;                                     // when timer reaches 0, will be set to exactly 0
            increasedGrav = false;                          // shows that increased gravity is off
            changeGravity();                                // calls function to change gravity
        }
    }

    // function will add time to timer, and set gravity to increased
    public void addTime(float time)
    {
        //Debug.Log("adding time");
        timer += time;                                      // increases timer by a passed time
        increasedGrav = true;                               // shows that increased gravity is on
        changeGravity();                                    // calls function to change gravity
    }


    // function to change gravity based on whether increased gravity is on
    private void changeGravity()
    {
        if (increasedGrav)
        {
            Physics.gravity = new Vector3(0, newGravity, 0);
        }
        else
        {
            Physics.gravity = new Vector3(0, oldGravity, 0);
        }
    }
}
