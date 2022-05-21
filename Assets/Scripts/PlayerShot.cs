using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public static PlayerShot disparar;

    Rigidbody2D myRb;
    public float speed;

    void Awake()
    {
        disparar = this;
    }

    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myRb.velocity = new Vector2(0, +speed);

        //Destroy(gameObject, 3f);
    }

    /*public void Shot()
    {
        GameObject bala = ObjectPooler.SharedInstance.ContarBalas();
        if (bala != null)
        {
            bala.transform.position = this.transform.position;
            bala.transform.rotation = this.transform.rotation;
            bala.SetActive(true);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Muro"))
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }

        if (collision.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
            //Destroy(collision.gameObject);
        }
    }
}
