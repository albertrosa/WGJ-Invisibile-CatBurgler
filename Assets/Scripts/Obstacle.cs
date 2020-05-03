using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool instant_death = false;
    public bool damage_health = false;

    public int value = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            PlayerStats player = other.GetComponent<PlayerStats>();
            if (damage_health)
            {
                Debug.Log("Player Takes Damage");
                // Apply Damage
                player.takeDamage(value);
            }

            if (instant_death)
            {
                player.kill();
            }
            else
            {
                Destroy(gameObject);
            }
        } else {
            Destroy(gameObject);
        }

      }
    
}
