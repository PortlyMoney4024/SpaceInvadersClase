using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
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
