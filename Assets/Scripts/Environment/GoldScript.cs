using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : PickaxeTargetScript
{
    public int goldScore = 1;
    public PlayerStats playerStatsScript;

    void Awake()
    {
        playerStatsScript = FindObjectOfType<PlayerStats>();
    }

    public override void Break()
    {
        playerStatsScript.GatherGold(goldScore);
        GameManager.instance.goldAmount += goldScore;
        GameManager.instance.allGoldAmount += goldScore;
        
        base.Break();

        AudioManager.instance.Play("GoldBreak");
    }
}
