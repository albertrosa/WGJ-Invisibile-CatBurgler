using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool restore_cloak = false;
    public bool restores_health = false;
    public bool damage_health = false;

    public int points = 0;
    public int value = 0;

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
