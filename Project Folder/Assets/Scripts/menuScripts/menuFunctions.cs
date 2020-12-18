using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuFunctions : MonoBehaviour
{
    // main menu functions so buttons will work
    public GameObject menu;
    public GameObject levles;

    // shows the how to play menu
    public void showMenu()
    {
        menu.SetActive(true);
    }

    // hides the how to play menu
    public void hideMenu()
    {
        menu.SetActive(false);
    }

    // loads the first level
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    // exits game
    public void exit()
    {
        Application.Quit();
    }

    // shows the level select menu
    public void showLevels()
    {
        levles.SetActive(true);
    }

    // hides the level select menu
    public void hideLevels()
    {
        levles.SetActive(false);
    }

    // loads a certian level
    // used for the level select buttons and the back buttons
    public void loadLevel(int i)
    {
        if (i >= 0 && i <= 6)
            SceneManager.LoadScene(i);
    }
}
