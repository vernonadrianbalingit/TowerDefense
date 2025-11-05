using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
//Christopher's Script
public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    //this is the name of the volume paramter that is set in the audio mixer
    public string volumeParameter;
    public Dropdown resolutionDropdown;
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public AudioClip clickSound;

    Resolution[] resolutions;

    private bool startSound = true;
    //pull list of all avaible resolutions from users display
    void Start()
    {
        resolutionStart(0);
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        startSound = false;
    }
    //set default resolution when game first loads
    public void resolutionStart(int resIndex)
    {
        if (startSound)
        {
            resolutions = Screen.resolutions;
        }
        else
        {
            SetResolution(resIndex);
        }
    }
    //set the resolution
    public void SetResolution(int resolutionIndex)
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    //adjust the volume
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat(volumeParameter, volume);
    }
    //toggle graphics quality
    public void SetQualityLevel(int qualityIndex)
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    //toggle fullscreen
    public void SetFullscreen(bool isFullscreen)
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        Screen.fullScreen = isFullscreen;
    }
    //return to main menu
    public void backToMainMenu()
    {
        if (clickSound != null && GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(clickSound);
        }
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
}
