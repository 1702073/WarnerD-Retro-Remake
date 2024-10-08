using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyScore = 50;

    public int health = 3;

    
    public void TakeDamage(int damage)
    {

        health -= damage;

        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        ScoreManager.currentScore += enemyScore;
        Destroy(gameObject);

        if (ScoreManager.currentScore >= PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", ScoreManager.currentScore);
        }
    }
}
