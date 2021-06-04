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
        AudioManager.instance.Play("ButtonUI");
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
        AudioManager.instance.Play("ButtonUI");
        SceneManager.LoadScene(1);
    }

    public void SkipTutorial()
    {
        AudioManager.instance.Play("ButtonUI");
        SceneManager.LoadScene(2);
    }

    public void Options()
    {
        AudioManager.instance.Play("ButtonUI");
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
        AudioManager.instance.Play("ButtonUI");
        if(resolution == 0)
            Screen.SetResolution(1920,1080, Screen.fullScreenMode);
        if(resolution == 1)
            Screen.SetResolution(1280,720, Screen.fullScreenMode);
    }

    public void ToggleFullscreen(bool toggleFullscreen)
    {
        AudioManager.instance.Play("ButtonUI");

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
        AudioManager.instance.Play("ButtonUI");
        Application.Quit();
    }
}
