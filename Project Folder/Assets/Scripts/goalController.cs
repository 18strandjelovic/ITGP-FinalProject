using Assets.Scripts.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalController : MonoBehaviour {
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            // load next level
            sceneService.LoadNextScene();
        }
    }
}
