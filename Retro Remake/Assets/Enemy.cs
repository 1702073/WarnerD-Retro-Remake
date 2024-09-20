using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 100;

    
    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Destroy(gameObject);
        Score = Score + 1;
    }
}
