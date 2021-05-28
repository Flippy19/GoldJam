using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public bool pauseActive;
    public GameObject pauseMenu;
    void Start()
    {
        pauseMenu.SetActive(false);
        pauseActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();    
        }
    }

    public void Pause()
    {
        if(!pauseActive)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            pauseMenu.SetActive(true);
            pauseActive = true;

            Time.timeScale = 0;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            pauseMenu.SetActive(false);
            pauseActive = false;

            Time.timeScale = 1;
        }
    }

    public void ExitToMenu()
    {
        //destroy MusicMenager
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
