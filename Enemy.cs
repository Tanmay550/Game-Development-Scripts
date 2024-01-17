using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;


public class Enemy : MonoBehaviour
{

    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D rb;
    private Transform currentPosition;
    public float speed = 2f;
    public float health = 100;
    public float atk = 50f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPosition = PointB.transform;
       
    }

    void Update()
    {
        Vector2 point = currentPosition.position - transform.position;
        if( currentPosition == PointB.transform)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
       if(Vector2.Distance(transform.position,currentPosition.position) < 0.5f && currentPosition == PointB.transform) 
        {
            Flip();
            currentPosition = PointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPosition.position) < 0.5f && currentPosition == PointA.transform)
        {
            Flip();
            currentPosition = PointB.transform;
        }
    }

    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    public void TakeDamage (float damage)
    {
        health -= damage;
        if(health < 0)
        {
            Die();
        }

    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = GetComponent<Player>();
        if(collision.gameObject.CompareTag("Player"))
        {
            player.TakeDmg(50);

        }
    }
}
