using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackedWallScript : PickaxeTargetScript
{
    public override void Break()
    {
        Debug.Log("Aaaa! My Wall! You monster...");
        base.Break();
    }
}
