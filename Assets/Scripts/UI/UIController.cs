using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public bool pauseActive;
    public GameObject pauseMenu;
    public GameObject deathScreen;
    
    void Awake()
    {
        pauseMenu.SetActive(false);
        pauseActive = false;

        deathScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.IsInputEnabled)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Pause();    
            }
        }

    }

    public void Pause()
    {
        if(!pauseActive)
        {
            AudioManager.instance.Play("ButtonUI");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            pauseMenu.SetActive(true);
            pauseActive = true;

            Time.timeScale = 0;
        }
        else
        {
            AudioManager.instance.Play("ButtonUI");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            pauseMenu.SetActive(false);
            pauseActive = false;

            Time.timeScale = 1;
        }
    }

    public void ExitToMenu()
    {
        AudioManager.instance.Play("ButtonUI");
        Time.timeScale = 1;
        GameManager.instance.IsInputEnabled = true;
        SceneManager.LoadScene(0);
    }
}
