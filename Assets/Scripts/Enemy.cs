using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;    
    public int damageLevel = 3;
    public bool cloaked = false;

    public int hitPoints = 1;
    public int killPoints = 2;
    
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerStats player = other.GetComponent<PlayerStats>();
            player.takeDamage(damageLevel);

            health -= player.getPowerDamage();
            player.addScore(hitPoints);

            if (health <= 0)
            {
                Destroy(gameObject);
                player.addScore(killPoints);
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
            player.addScore(hitPoints);

            if (health <= 0)
            {
                Destroy(gameObject);
                player.addScore(killPoints);
            };

        }
    }



}
