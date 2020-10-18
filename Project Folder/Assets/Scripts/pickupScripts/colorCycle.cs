using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorCycle : MonoBehaviour
{
    public Color[] rgb;                         // array red green and blue colors
    public float timerMax;                      // how fast the color transitions should be

    private int colorIndex;                     // index for the color array
    private int maxColors;                      // max number of colors in the color array
    private float currentTimer;                 // the current time out of  timerMax
    private Color currentColor;                 // current color of the cubes
    private Color nextColor;                    // next color to transition to


    void Start()
    {  
        // initializing varibles
        maxColors = 3;
        rgb = new Color[maxColors];
        colorIndex = 0;
        setColors();                                    // function fills color array with red green and blue
        currentTimer = 0f;
        currentColor = rgb[colorIndex];                 
        nextColor = rgb[pickColor(ref colorIndex)];     // function call to get and iterate next color index
        timerMax = .25f;
    }

    void Update()
    {
        // checking to see if timer has completed
        if (currentTimer >= timerMax)
        {
            // if timer has completed, will set the new current color, and get the next color
            // then resets the timer
            currentColor = rgb[colorIndex];
            nextColor = rgb[pickColor(ref colorIndex)];
            currentTimer = 0f;
        }

        // gradually changing to color from the current color to the next color based how much the timer has completed
        // then the timer goes up based on how long a fram took to render
        GetComponent<Renderer>().material.color = Color.Lerp(currentColor, nextColor, currentTimer/timerMax);
        currentTimer += Time.deltaTime;
    }

    // function to populate color array with correct colors
    // was not sure how else to do this
    private void setColors()
    {
        rgb[0] = new Color(1, 0, 0, 0);
        rgb[1] = new Color(0, 1, 0, 0);
        rgb[2] = new Color(0, 0, 1, 0);
    }

    // the pickColor() function will take the current index by reference and either reset it increment, the return
    // if the current index is already at the end of the color array, it will go back to 0, to avoid going out of bound
    private int pickColor(ref int i)
    {
        if (i == maxColors - 1)
        {
            i = 0;
            return i;
        }
        else
        {
            ++i;
            return i;
        }
    }
}