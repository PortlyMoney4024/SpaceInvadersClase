using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    float movX;
    public float speed;

    public Transform firePoint;
    public GameObject bala;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movX = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(bala, firePoint.position, Quaternion.identity);
            //PlayerShot.disparar.Shot();
            Shot();
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movX, 0)*speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            //Mando llamar el GM y sus funciones publicas desde cualquier script
            GameManager.sharedInstance.TakeDamage();
        }
    }

    public void Shot()
    {
        GameObject bala = ObjectPooler.SharedInstance.ContarBalas();
        if (bala != null)
        {
            bala.transform.position = this.transform.position;
            bala.transform.rotation = this.transform.rotation;
            bala.SetActive(true);
        }
    }
}
