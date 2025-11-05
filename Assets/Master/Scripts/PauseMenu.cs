using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Christopher's Script

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public static bool isPaused;
    public string mainMenuName;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

//open pause menu
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    //pause the game
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    //resume the game
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    //return to main menu
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
