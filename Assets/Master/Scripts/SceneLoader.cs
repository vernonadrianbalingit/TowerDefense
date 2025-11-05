using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        //LoadMenu();
    }

    //go to the menu scene
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Main Menu Loaded");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Forest");
        Debug.Log("Forest Scene, Level 1, Loaded");
    }
    
}
