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
        base.Break();

        Debug.Log("Nice nice, it was actually a fucking golden nugget <3");
    }

}
