using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private int health; // the player's current health

    public Text healthText; // text to display player's health

    public int maxHealth; // maximum health the player can have


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        UpdateHealthText();
    }
    public void ModifyHealth(int modifier)
    {
        health = health + modifier;

        if (health <= 0)
        {
            // the player is dead
            SceneManager.LoadScene(1);
        }

        // if the health goes over the maxHealth value, set to maxHealth
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        UpdateHealthText();
    }

    private void UpdateHealthText()
    {
        healthText.text = "Health: " + health; // "Health: 8"
    }
}
