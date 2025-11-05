using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Christopher's Script
public class LevelSelectMenu : MonoBehaviour
{


    public GameObject mainMenu;
    public GameObject levelSelectMenu;
    public AudioClip clickSound;
    //return to main menu
    public void backToMainMenu()
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        mainMenu.SetActive(true);
        levelSelectMenu.SetActive(false);
    }
}
