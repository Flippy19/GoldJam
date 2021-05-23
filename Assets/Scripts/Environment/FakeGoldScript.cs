using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGoldScript : PickaxeTargetScript
{
    void Start()
    {
        
    }

    public override void Break()
    {
        Debug.Log("It was fake, you fucking donkey!");
        base.Break();
    }
}
