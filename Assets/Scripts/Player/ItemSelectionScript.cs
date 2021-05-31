using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelectionScript : MonoBehaviour
{
    public GameObject pickaxe;
    public GameObject lamp;

    public bool holdPickaxe = true;
    public bool holdLamp = false;

    private PickaxeTargetScript[] allPickaxeTargetArray;
    public List<PickaxeTargetScript> allPickaxeTargetList = new List<PickaxeTargetScript>();

    public Animator animator;

    void Awake()
    {
        //Get all GameObjects in Scene and put it in the Array
        allPickaxeTargetArray = FindObjectsOfType<PickaxeTargetScript>();
        animator = GetComponent<Animator>();

        //Convert Array to List
        foreach(PickaxeTargetScript target in allPickaxeTargetArray)
        allPickaxeTargetList.Add(target);
    }

    void Update()
    {
        if(GameManager.instance.IsInputEnabled)
        {
            //Input 1 on Keyboard to choose Pickaxe
            if(Input.GetKeyDown(KeyCode.Alpha1) && holdLamp)
            {
                SetToPickaxe();
                ParticularParticlesStop();
            }

            //Input 2 on Keyboard to choose Lamp
            if(Input.GetKeyDown(KeyCode.Alpha2) && holdPickaxe)
            {
                SetToLamp();
            }
        }
    }

    void SetToPickaxe()
    {
        holdLamp = false;
        holdPickaxe = true;

        animator.SetTrigger("ChangeToPickaxe");
    }

    void SetToLamp()
    {
        holdLamp = true;
        holdPickaxe = false;

        animator.SetTrigger("ChangeToLamp");
    } 

    void ParticularParticlesStop()
    {
        //Remove missing object in list
        for(var i = allPickaxeTargetList.Count - 1; i > -1; i--)
        {
            if(allPickaxeTargetList[i] == null)
            allPickaxeTargetList.RemoveAt(i);
        }

        //For every object in allPickaxeTargetList List check layer and existance of ParticleSystem then Stop it
        foreach(PickaxeTargetScript target in allPickaxeTargetList)
        {
            if(target.gameObject.layer == 9 || target.gameObject.layer == 10)
            {
                if(target.GetComponent<ParticleSystem>() != null)
                {
                    target.GetComponent<ParticleSystem>().Stop();
                }
            }
        }
    }
}
