using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool instantDeath = false;
    public bool damageHealth = false;
    [SerializeField] bool destroyAfterCollision = false;
    public int value = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player gets hit");

            PlayerStats player = other.GetComponent<PlayerStats>();
            if (damageHealth)
            {
                Debug.Log("Player Takes Damage");
                // Apply Damage
                player.takeDamage(value);
            }

            if (instantDeath)
            {
                Debug.Log("Player Instant Death!");
                player.kill();
            }
            else
            {
                if(destroyAfterCollision) 
                    Destroy(gameObject);
            }
        } 

      }
    
}
