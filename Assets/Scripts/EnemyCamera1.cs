using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCamera1 : MonoBehaviour
{

    [SerializeField] int health = 1;
    [SerializeField] int damageLevel = 3;
    [SerializeField] bool cloaked = false;

    [SerializeField] int hitPoints = 3;  

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
            };
        }
    }
    
}
