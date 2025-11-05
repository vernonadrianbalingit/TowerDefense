using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Christopher's Script
public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject shopMenu;
    public GameObject levelSelectMenu;
    public AudioClip clickSound;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
        shopMenu.SetActive(false);
        levelSelectMenu.SetActive(false);
    }

    // Update is called once per frame
    public void GoToLevelSelectMenu()
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        mainMenu.SetActive(false);
        levelSelectMenu.SetActive(true);
    }
    public void GoToShopMenu()
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        mainMenu.SetActive(false);
        shopMenu.SetActive(true);
    }
    public void GoToSettingsMenu()
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void QuitGame()
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        Application.Quit();
    }
}
