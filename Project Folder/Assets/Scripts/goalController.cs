using Assets.Scripts.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalController : MonoBehaviour {
    // references to the score and timer objects
    public scoreCounter score;
    public timer timeScore;

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            
            // need to get time from timer object with getTime() 
            // and use a per level function to get the time score
            // then add to scre to see if it beats high score

            // setting high score in player prefs
            if (score.getScore() > PlayerPrefs.GetInt(score.getSceneName(), 0))
                PlayerPrefs.SetInt(score.getSceneName(), score.getScore());

            sceneService.LoadNextScene();       // load next level
        }
    }

}
