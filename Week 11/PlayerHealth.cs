using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;
    public TMP_Text healthText;

    void Start()
    {
        UpdateUI();
    }

    void Update()
    {
        UpdateUI();
    }

    public bool Heal(int amount)
    {
        // If playerhealth == 100, do nothing!
        if (health >= maxHealth)
        {
            return false;
        }

        // Else health +10 (capped at 100)
        health = Mathf.Min(health + amount, maxHealth);
        UpdateUI();
        return true;
    }

    private void UpdateUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + health;
        }
    }
}
