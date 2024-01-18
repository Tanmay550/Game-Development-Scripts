using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float health = 100;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   

    public void TakeDmg(float damage) 
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }



    private void Die()
    {
        Destroy(gameObject);
    }

    
   
}
