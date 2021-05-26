using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGoldScript : PickaxeTargetScript
{
    int damage = 1;
    public PlayerStats playerStatsScript;

    void Awake()
    {
        playerStatsScript = FindObjectOfType<PlayerStats>();
    }

    public override void Break()
    {
        base.Break();
        playerStatsScript.TakeDamage(damage);
        
        Debug.Log("It was fake, you fucking donkey!");
    }
}
