using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum Scenes
{
    Start = 0,
    GAMEOVER = 1,
    Intro = 2
}

public class Menu : MonoBehaviour
{
    public void startGame()
    {
        Debug.Log("Starting Intro Game");
        SceneManager.LoadScene( (int) Scenes.Intro);
    }

    public void endGame()
    {
        Debug.Log("Quiting Game");
        Application.Quit();
    }

    public void StartMenu()
    {
        SceneManager.LoadScene((int)Scenes.Start);
    }

    public void restartLevel()
    {
        int lastLevel = PlayerPrefs.GetInt("LAST_LEVEL");
        SceneManager.LoadScene(lastLevel);
    }
}
