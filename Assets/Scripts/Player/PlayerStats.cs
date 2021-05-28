using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats: MonoBehaviour
{
    public float health = 3;
    public int gold = 0;

    public HudController hudController;

    void Start()
    {
        hudController = FindObjectOfType<HudController>();
    }
    public void GatherGold(int goldScore)
    {
        gold += goldScore;
        hudController.RefreshGold(gold);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        hudController.RefreshHealth(health);
        CheckIfAlive();
    }

    void CheckIfAlive()
    {
        if(health <= 0)
        {
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        Debug.Log("Rest in pieces");
        
        yield return new WaitForSeconds(1f);

    }

}
