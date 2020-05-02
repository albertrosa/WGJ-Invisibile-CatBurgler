using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    bool instant_death = false;
    bool damage_health = false;

    int points = 0;
    int value = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
            if (damage_health)
            {
                Debug.Log("Player Takes Damage");
                // Apply Damage
            }

            Destroy(gameObject);
      }
    
}
