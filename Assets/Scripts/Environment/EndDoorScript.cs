using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndDoorScript : MonoBehaviour
{
    public PlayerStats playerStatsScript;
    public int goldNeeded = 25;
    public int playerGold;

    void Awake()
    {
        playerStatsScript = FindObjectOfType<PlayerStats>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == 6)
        {
            playerGold = playerStatsScript.gold;
            CheckAmountOfGold();
        }
    }

    void CheckAmountOfGold()
    {
        if(playerGold >= goldNeeded)
        {
            GameEnd();
        }
        else
        Debug.Log("Need. More. GOLD!");
    }

    void GameEnd()
    {
        SceneManager.LoadScene(3);
        Debug.Log("Yay! You won the game");
    }
}
