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


            int total = score.getScore() + (int)Mathf.Round(500 / timeScore.getTime());

            // setting high score in player prefs
            if (total > PlayerPrefs.GetInt(score.getSceneName(), 0))
                PlayerPrefs.SetInt(score.getSceneName(), total);

            sceneService.LoadNextScene();       // load next level
        }
    }

}
