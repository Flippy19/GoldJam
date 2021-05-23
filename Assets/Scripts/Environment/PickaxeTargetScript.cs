using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeTargetScript : MonoBehaviour
{
    public float health = 3f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0f)
        {
            Break();
        }
    }

    public virtual void Break()
    {
        Destroy(gameObject);
    }
}
