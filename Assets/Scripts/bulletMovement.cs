using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    Rigidbody2D balaRb;

    //Usamos este en vez de start cuando utilizamos object pooling
    void OnEnable()
    {
        balaRb = GetComponent<Rigidbody2D>();
        balaRb.velocity = new Vector2(0, -1);
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Muro"))
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }

        if(collision.CompareTag("PlayerShot"))
        {
            gameObject.SetActive(false);
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
    }
}
