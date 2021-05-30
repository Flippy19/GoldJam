using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public UIController uiController;

    void Start()
    {
        Cursor.visible = true;
    }
    
    public void Resume()
    {
        uiController.Pause();
    }

    public void MuteSounds(bool mute)
    {
        if(mute)
        AudioManager.instance.gameObject.SetActive(false);
        else
        AudioManager.instance.gameObject.SetActive(true);
    }

    public void ExitToMenu()
    {
        GameManager.IsInputEnabled = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
