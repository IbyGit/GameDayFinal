using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // var healthComponent = other.GetComponent<Health>();
            // if (healthComponent != null)
            // {
            //     healthComponent.TakeDamage(1);
            // }
        }
    }
}
