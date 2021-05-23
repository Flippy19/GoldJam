using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeScript : MonoBehaviour
{
    public float damage = 1f;
    public float range = 10f;
    public float hitRate = 15f;

    public Camera playerCamera;
    public GameObject hitEffect;

    private float nextTimeToHit = 0f;

    void Start()
    {
        playerCamera = Camera.main;
    }

    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time >= nextTimeToHit)
        {
            nextTimeToHit = Time.time + 1f/hitRate;
            PickaxeHit();
        }
    }

    void PickaxeHit()
    {
        RaycastHit hit;
        if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            PickaxeTargetScript pickaxeTarget = hit.transform.GetComponent<PickaxeTargetScript>();

            if(pickaxeTarget != null)
            {
                pickaxeTarget.TakeDamage(damage);
            }

            GameObject hitEffectInst = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(hitEffectInst, 1f);

        }
    }


}
