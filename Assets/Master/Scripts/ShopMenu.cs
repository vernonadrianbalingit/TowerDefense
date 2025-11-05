using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Christopher's Script

public class ShopMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject shopMenu;
    public AudioClip clickSound;
    //return to main menu
    public void backToMainMenu()
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        mainMenu.SetActive(true);
        shopMenu.SetActive(false);
    }
}
