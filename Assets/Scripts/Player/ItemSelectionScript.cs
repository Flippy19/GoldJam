using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelectionScript : MonoBehaviour
{
    public GameObject pickaxe;
    public GameObject lamp;

    public bool holdPickaxe = true;
    public bool holdLamp = false;

    private GameObject[] allGoArray;
    public List<GameObject> allGoList = new List<GameObject>();

    void Awake()
    {
        //Get all GameObjects in Scene and put it in the Array
        allGoArray = FindObjectsOfType<GameObject>();

        //Convert Array to List
        foreach(GameObject GO in allGoArray)
        allGoList.Add(GO);
    }

    void Update()
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

    void SetToPickaxe()
    {
        holdLamp = false;
        holdPickaxe = true;

        pickaxe.SetActive(true);
        lamp.SetActive(false);
    }

    void SetToLamp()
    {
        holdLamp = true;
        holdPickaxe = false;

        pickaxe.SetActive(false);
        lamp.SetActive(true);
    } 
    void ParticularParticlesStop()
    {
        for(var i = allGoList.Count - 1; i > -1; i--)
        {
            if(allGoList[i] == null)
            allGoList.RemoveAt(i);
        }

        //For every GameObject in allGoList List check layer and existance of ParticleSystem then Stop it
        foreach(GameObject GO in allGoList)
        {
            if(GO.layer == 9 || GO.layer == 10)
            {
                if(GO.GetComponent<ParticleSystem>() != null)
                {
                    GO.GetComponent<ParticleSystem>().Stop();
                }
            }
        }
    }
}
