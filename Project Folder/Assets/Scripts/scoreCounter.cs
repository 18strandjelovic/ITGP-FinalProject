using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCounter : MonoBehaviour
{
    private static int currentScore;                    // counter for the player's current score

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;                               // initializing score to 0
        //Debug.Log("Begining score: " + currentScore);
    }

    public static void addPoints(int value)
    {
        currentScore += value;                          // add score amout to current score
        //Debug.Log("current score: " + currentScore);
    }

    int getScore()
    {
        return currentScore;                            // since score is private, this will return the score
    }
}
