using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackedWallScript : PickaxeTargetScript
{
    void Start()
    {
        
    }

    public override void Break()
    {
        Debug.Log("Aaaa! My Wall! You monster...");
        base.Break();
    }
}
