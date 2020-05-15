using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;    
    public int damageLevel = 3;
    public bool cloaked = false;

    public int hitPoints = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            PlayerStats player = other.GetComponent<PlayerStats>();
            player.takeDamage(damageLevel);

            health -= player.getPowerDamage();

            if (health <= 0)
            {
                Destroy(gameObject);
            };

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerStats player = other.gameObject.GetComponent<PlayerStats>();
            player.takeDamage(damageLevel);

            health -= player.getPowerDamage();

            if (health <= 0)
            {
                Destroy(gameObject);
            };

        }
    }


}
