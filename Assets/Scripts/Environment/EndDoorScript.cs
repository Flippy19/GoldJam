using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            GameWin();
        }
        else
        Debug.Log("Need. More. GOLD!");
    }

    void GameWin()
    {
        Debug.Log("Yay! You won the game");
    }
}
