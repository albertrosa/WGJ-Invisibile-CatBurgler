using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public int maxHealth = 3;
    public int health;
    public int strength = 2;
    public int strengthBooster = 1;
    public bool boosted = false;    
    int score;

    public Text scoreText;
    public Text healthText;

    private void Start()
    {
        this.healthText.text = this.health.ToString();
    }

    public int getPowerDamage() {
        return (boosted) ? strength * strengthBooster : strength;
    }

    public void takeDamage(int damage)
    {
        this.health -= damage;
        this.healthText.text = this.health.ToString();
    }

    public void heal(int heal)
    {
        this.health += heal;
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
        this.scoreText.text = this.score.ToString();
    }

    public void kill()
    {
        this.health = 0;
        this.healthText.text = this.health.ToString();
    }
}
