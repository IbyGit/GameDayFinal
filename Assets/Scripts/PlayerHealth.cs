using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // public static event Action OnPlayerDamaged;
    // public static event Action OnPlayerDeath;

    public int maxHealth = 3;
    public int health;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage (int amount) {
        health -= amount;
        if (health <= 0)
        {
            anim.SetBool("IsDead", true);
            //todo show game over screen
        }
    }
}
