using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool restores_health = false;
    public bool damage_health = false;

    public int points = 0;
    public int value = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if  (other.CompareTag("Player"))
        {
            PlayerStats playerStats = other.GetComponent<PlayerStats>();
            if (restores_health)
            {
                Debug.Log("Here we restore health");
                // apply health
                playerStats.heal(this.value);
            }

            if (damage_health)
            {
                Debug.Log("Player Takes Damage");
                // Apply Damage
                playerStats.takeDamage(this.value);
            }

            playerStats.addScore(this.points);
            Destroy(gameObject);
        }

    }


}
