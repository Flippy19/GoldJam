using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialRandomizerScript : MonoBehaviour
{
    public Material[] material = new Material[3];
    void Awake()
    {
        GetComponent<MeshRenderer>().material = material[Random.Range(0,3)];
    }
}
