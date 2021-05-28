using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HudController : MonoBehaviour
{
    public float playerHealth;
    public int goldAmount;

    public Image healthImage;
    public TextMeshProUGUI goldAmountText;

    public PlayerStats playerStats;
    
    void Start()
    {
        playerStats = FindObjectOfType<PlayerStats>();

        playerHealth = playerStats.health;
        goldAmount = playerStats.gold;
    }

    public void RefreshHealth(float health)
    {
        playerHealth = health;
        healthImage.fillAmount = health/3;
    }

    public void RefreshGold(int gold)
    {
        goldAmount = gold;
        goldAmountText.text = goldAmount.ToString();
    }
}
