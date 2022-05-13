using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    float movX;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movX = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movX, 0)*speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            //Mando llamar el GM y sus funciones publicas desde cualquier script
            GameManager.sharedInstance.TakeDamage();
        }
    }
}
