using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class massPickup : MonoBehaviour
{
    public int durration;                       // how long increased gravity should go for

    private GameObject grav;                    // gravity controller object

    private void Start()
    {
        grav = GameObject.FindGameObjectWithTag("gravController");      // finds grav controller object
    }


    // if player picks up "mass" modifier, will increas the gravity
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            grav.transform.SendMessage("addTime", durration);           // yells at gravity controller to increase the gravity for durration seconds
            Destroy(gameObject);                                        // removes game object from play
            //Debug.Log("changing gravity");
        }
    }
}
