using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class DoorScript : MonoBehaviour
{
    public PlayerStats playerStatsScript;
    public HudController hudController;
    public TextMeshPro goldNeededText;

    public int goldNeeded = 25;
    public bool doorOpened = false;

    public Animator animator;

    void Awake()
    {
        playerStatsScript = FindObjectOfType<PlayerStats>();
        hudController = FindObjectOfType<HudController>();
        goldNeededText = transform.GetChild(0).GetComponent<TextMeshPro>();
        animator = transform.parent.GetComponent<Animator>();

        goldNeededText.text = goldNeeded.ToString();
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == 6)
        {
            CheckAmountOfGold();
        }
    }

    void CheckAmountOfGold()
    {
        if(playerStatsScript.gold >= goldNeeded)
        {
            playerStatsScript.gold = playerStatsScript.gold - goldNeeded;
            GameManager.instance.goldAmount = playerStatsScript.gold;
            
            hudController.RefreshGold(playerStatsScript.gold);
            Open();
        }
    }

    void Open()
    {
        if(!doorOpened)
        {
            doorOpened = true;
            animator.SetBool("DoorOpened", true);
            Debug.Log("The door has been opened");

            Destroy(gameObject, 3.0f);
        }

    }
}
