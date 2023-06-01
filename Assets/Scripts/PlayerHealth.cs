using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;
    public Animator anim;
    public Rigidbody2D rb;

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
            Invoke("GameOver", 3);
        }
    }

    public void GameOver () {
        SceneManager.LoadScene("DeathScreen");
    }

    private void Die ()
    {
        rb.bodyType = RigidbodyType2D.Static;
        GetComponent<PlayerMovement>().enabled = false;
        anim.SetTrigger("Death");
    }
}
