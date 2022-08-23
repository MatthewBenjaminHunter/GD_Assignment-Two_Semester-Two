using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Healthbar healthbar;


    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }

    public void IncreaseHealth(int health)
    {
        
        if(currentHealth + health < 100)
        {
            currentHealth += health;
            healthbar.SetHealth(currentHealth);
        }
        else
        {
            currentHealth = maxHealth;
        }
 
    }

}
