using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public bool countDown;          // wether or not the time should count up or down
                                    // for maps where if you complete it in a given time you get points 
                                    // or no points if you dont complete it in time
    public float timerDown;
    public Text timerText;          // display for the timer

    private float timerUp;          // the time it takes to complete a level will affect score
                                    // faster completions will lead to mor epoints

    // Start is called before the first frame update
    void Start()
    {
        timerUp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // counting timer up or down baed on bool
        // can be set per level
        if (countDown)
        {   
            if (timerDown > 0)
                timerDown -= Time.deltaTime;
            if (timerDown < 0)
                timerDown = 0;
            timerText.text = timerDown.ToString();
        }
        else
        {
            timerUp += Time.deltaTime;
            timerText.text = timerUp.ToString("F2");
        }
    }

    // returns time for the level
    public float getTime()
    {
        if (countDown)
            return timerDown;
        else
            return timerUp;
    }
}
