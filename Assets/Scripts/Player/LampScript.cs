using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == 9)
        {
            collision.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>().Play();
        }

        if(collision.gameObject.layer == 10)
        {
            collision.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>().Play();
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.layer == 9)
        {
            collision.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>().Stop();
        }

        if(collision.gameObject.layer == 10)
        {
            collision.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>().Stop();
        }

    }
}
