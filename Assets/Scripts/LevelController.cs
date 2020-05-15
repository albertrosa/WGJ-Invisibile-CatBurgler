using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static bool isPaused = false;

    [SerializeField] GameObject player;
    PlayerStats stats;

    // Start is called before the first frame update
    void Start()
    {
        stats = player.GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {

        if (stats == null)
            stats = player.GetComponent<PlayerStats>();

        if (stats.getHealth() <= 0)
        {
            Debug.Log("Player is Dead!");
            this.GameOver();
        }

        if (Input.GetButtonDown("Pause"))
        {
            GamePaused();
        }
    }

    void GameOver()
    {
        int finalScore = stats.getScore();
        PlayerPrefs.SetInt("LAST_SCORE", finalScore);
        PlayerPrefs.SetInt("LAST_LEVEL", SceneManager.GetActiveScene().buildIndex);

        // here we want to play any special audio and be able to control the screen view
        PlayerMovement pm = player.GetComponent<PlayerMovement>();
        pm.OnDeath();

        // Player cannot be played with anymore
        Destroy(player);

        Debug.Log("GameOver");
        SceneManager.LoadScene(1);
    }

    void GamePaused()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Debug.Log("Paused");            
            Time.timeScale = 0f;
            // he sure to stop all animations at this this point
        } else
        {
            GameResumed();
        }
    }

    void GameResumed()
    {
        Debug.Log("Resumed");
        Time.timeScale = 1f;
        // here we resume the game 
    }

    void StartMenu()
    {
        Debug.Log("Start menu Loads now");
        // SceneManager.LoadScene("StartMenu");
    }


}
