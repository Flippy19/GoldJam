using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGameScript : MonoBehaviour
{
    public GameObject credits;
    public TextMeshPro finalGoldAmount;

    void Start()
    {
        credits.SetActive(false);
        finalGoldAmount = credits.transform.GetChild(0).GetComponent<TextMeshPro>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == 6)
        {
            credits.SetActive(true);
            finalGoldAmount.text = GameManager.instance.allGoldAmount.ToString() + "/83 Golden nuggets";
            Destroy(gameObject);
        }
    }
}
