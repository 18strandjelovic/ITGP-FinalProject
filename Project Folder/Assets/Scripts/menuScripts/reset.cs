using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    // this is for the win screen
    // it will wait 3 seconds, then goes to the main menu
    void Start()
    {
        StartCoroutine("wait");  
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
