﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool instant_death = false;
    public bool damage_health = false;

    public int points = 0;
    public int value = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerStats player = other.GetComponent<PlayerStats>();
            if (damage_health)
            {
                Debug.Log("Player Takes Damage");
                // Apply Damage
                player.takeDamage(value);
            } 

        if (damage_health)
        {
            player.kill();
        }



            Destroy(gameObject);
      }
    
}
