using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {
        StartCoroutine(enemyShoot());
    }

    IEnumerator enemyShoot()
    {
        do
        {
            yield return new WaitForSeconds(1);
            Instantiate(bullet, transform);
        } while (true);
    }
}
