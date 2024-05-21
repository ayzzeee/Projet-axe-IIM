using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtk : MonoBehaviour
{
    public int damage;
    public HeroHealth health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "Player")
            {
                    health.TakeDamage(damage);
                    Debug.Log("Player Destroyed");
            }
    }
}