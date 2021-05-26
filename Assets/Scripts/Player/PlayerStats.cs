using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats: MonoBehaviour
{
    public int health = 1;
    public int gold = 0;

    public void GatherGold(int goldScore)
    {
        gold += goldScore;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
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
