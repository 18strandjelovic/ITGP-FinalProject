using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public string sceneName;
    public Text scoreValue;
    public Text highScore;

    private static int currentScore;                    // counter for the player's current score
    private int currentHighScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;                                       // initializing score to 0
        scoreValue.text = currentScore.ToString();
        currentHighScore = PlayerPrefs.GetInt(sceneName, 0);    // loading highscore from player prefs
        highScore.text = currentHighScore.ToString();
        //Debug.Log("Begining score: " + currentScore);
    }

    private void Update()
    {
        // displaying current score
        scoreValue.text = currentScore.ToString();
        
        // updating highscore if current score beats it
        if (currentScore > currentHighScore)
        {
            currentHighScore = currentScore;
            highScore.text = currentHighScore.ToString();
        }
    }

    public static void addPoints(int value)
    {
        currentScore += value;          // add score amout to current score
        //Debug.Log("current score: " + currentScore);
    }

    public int getScore()
    {
        return currentScore;            // since score is private, this will return the score
    }

    // using this to store high score in player prefs
    public string getSceneName()
    {
        return sceneName;
    }
}
