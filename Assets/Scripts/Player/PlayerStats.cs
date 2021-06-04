using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats: MonoBehaviour
{
    public float health = 3;
    public int gold = 0;

    public HudController hudController;
    public GameObject deathScreen;

    void Awake()
    {
        hudController = FindObjectOfType<HudController>();
        //gold = GameManager.instance.goldAmount;

        GatherGold(GameManager.instance.goldAmount);
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
        GameManager.instance.IsInputEnabled = false;
        AudioManager.instance.Play("Death");

        yield return new WaitForSeconds(1f);

        deathScreen.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}
