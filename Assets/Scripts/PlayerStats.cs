using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] int maxHealth = 3;
    [SerializeField] int health;
    [SerializeField] int strength = 2;
    [SerializeField] int strengthBooster = 1;
    [SerializeField] bool boosted = false;    
    int score;

    public Text scoreText;
    public Text healthText;

    private void Start()
    {
        if (healthText)
            this.healthText.text = this.health.ToString();
    }

    public int getPowerDamage() {
        return (boosted) ? strength * strengthBooster : strength;
    }

    public void takeDamage(int damage)
    {
        this.health -= damage;
        if (healthText)
            this.healthText.text = this.health.ToString();
    }

    public void heal(int heal)
    {
        this.health += heal;
        if (healthText)
            this.healthText.text = this.health.ToString();
    }

    public int getHealth()
    {
        return this.health;
    }

    public int getScore()
    {
        return score;
    }

    public void addScore(int points)
    {
        this.score += points;
        if (scoreText)
            this.scoreText.text = this.score.ToString();
    }

    public void kill()
    {
        this.health = 0;
        if (healthText)
            this.healthText.text = this.health.ToString();
    }
}
