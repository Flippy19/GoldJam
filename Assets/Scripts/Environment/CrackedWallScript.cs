using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackedWallScript : PickaxeTargetScript
{
    public override void Break()
    {
        AudioManager.instance.Play("Wall");
        base.Break();
    }
}
