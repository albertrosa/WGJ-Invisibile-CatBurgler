﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    bool restore_cloak = false;
    bool restores_health = false;
    bool damage_health = false;

    int points = 0;
    int value = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if  (other.CompareTag("Player"))
        {
            if (restores_health)
            {
                Debug.Log("Here we restore health");
                // apply health
            }

            if(restore_cloak)
            {
                Debug.Log("Here we restore Cloak");
                // apply Cloak
            }

            if (damage_health)
            {
                Debug.Log("Player Takes Damage");
                // Apply Damage
            }

            Destroy(gameObject);
        }

    }


}
