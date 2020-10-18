using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorePickup : MonoBehaviour
{
    public int scoreValue;                          // value to increase score by


    // increases score if player picks up socre pickup
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")          
        {
            scoreCounter.addPoints(scoreValue);     // tells thescore manager to add scoreValue points
            Destroy(gameObject);                    // removes pickup from play
        }
    }
}
