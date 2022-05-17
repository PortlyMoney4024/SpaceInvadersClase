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
}
