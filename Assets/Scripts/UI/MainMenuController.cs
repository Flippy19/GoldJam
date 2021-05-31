using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{
    public bool optionsActive;
    public GameObject optionsMenu;

    public bool startGameMenuActive;
    public GameObject startGameMenu;

    void Awake()
    {
        optionsActive = false;
        optionsMenu.SetActive(false);

        startGameMenu.SetActive(false);
        startGameMenuActive = false;
        
        Cursor.visible = true;
    }

    public void ShowStartGameMenu()
    {
        if(!startGameMenuActive)
        {
            startGameMenu.SetActive(true);
            startGameMenuActive = true;
        }
        else
        {
            startGameMenu.SetActive(false);
            startGameMenuActive = false;
        }
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SkipTutorial()
    {
        SceneManager.LoadScene(2);
    }

    public void Options()
    {
        if(!optionsActive)
        {
            optionsMenu.SetActive(true);
            optionsActive = true;
        }
        else
        {
            optionsMenu.SetActive(false);
            optionsActive = false;
        }
    }

    public void ChangeResolution(int resolution)
    {   
        if(resolution == 0)
            Screen.SetResolution(1920,1080, Screen.fullScreenMode);
        if(resolution == 1)
            Screen.SetResolution(1280,720, Screen.fullScreenMode);
    }

    public void ToggleFullscreen(bool toggleFullscreen)
    {
        if(toggleFullscreen)
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        else
            Screen.fullScreenMode = FullScreenMode.Windowed;

    }

    public void MuteSounds(bool mute)
    {
        if(mute)
            AudioManager.instance.gameObject.SetActive(false);
        else
            AudioManager.instance.gameObject.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
