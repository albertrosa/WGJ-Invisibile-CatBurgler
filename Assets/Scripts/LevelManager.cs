using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    GameObject Player;
    public int health = 3;
    public int scoreMultiplier = 1;
    public int timeLimit = 30; // set a timer TBD

    int score = 0;

    public void takeDamage(int dmg)
    {
        this.health = -dmg;
    }

    public void instantKill()
    {
        this.health = 0;
    }

    public void restoreHealth(int restore)
    {
        this.health += restore;
    }

    public void setScore(int score)
    {
        this.score = score;
    }


}
