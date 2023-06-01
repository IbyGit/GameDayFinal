using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;
    public Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            health -= 1;
        }
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die ()
    {
        anim.SetTrigger("Death");
    }
}
