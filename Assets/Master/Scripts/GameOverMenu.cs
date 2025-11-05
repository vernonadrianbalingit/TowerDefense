using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Christopher's Script

public class GameOverMenu : MonoBehaviour
{

    public GameObject gameOverMenu;
    public static bool isGameOver;
    public string mainMenuName;
    void Start()
    {
        gameOverMenu.SetActive(false);
    }
    //switch to game over menu
    void Update()
    {
        if (isGameOver)
        {
            gameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    //switch to main menu
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuName);
    }
    //quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}

