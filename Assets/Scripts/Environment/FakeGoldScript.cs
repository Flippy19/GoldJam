using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGoldScript : PickaxeTargetScript
{
    int damage = 1;
    public PlayerStats playerStats;

    void Awake()
    {
        playerStats = FindObjectOfType<PlayerStats>();
    }

    public override void Break()
    {
        base.Break();
        playerStats.TakeDamage(damage);
        AudioManager.instance.Play("Explosion");

    }
}
