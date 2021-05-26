using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeTargetScript : MonoBehaviour
{
    public float health = 3f;
    public GameObject breakPartcilesObject;
    GameObject particlesInstance;
    ParticleSystem objectParticleSystem;

    void Awake()
    {
        objectParticleSystem = breakPartcilesObject.transform.GetChild(0).GetComponent<ParticleSystem>();
    }

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
        particlesInstance = Instantiate(breakPartcilesObject, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(particlesInstance, 2.0f);
    }
}
