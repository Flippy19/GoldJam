using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : PickaxeTargetScript
{
    void Start()
    {
        
    }

    public override void Break()
    {
        Debug.Log("Nice nice, it was actually a fucking golden nugget <3");
        base.Break();
    }

}
