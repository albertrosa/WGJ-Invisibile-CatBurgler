using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    int health;
    int score;

    public void takeDamage(int damage)
    {
        this.health -= damage;
    }

    public void heal(int heal)
    {
        this.health += heal; 
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

    }
}
