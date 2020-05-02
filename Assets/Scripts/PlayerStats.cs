using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int health;
    public int score;

    public Text scoreText;

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
        this.scoreText.text = this.score.ToString();
    }
}
