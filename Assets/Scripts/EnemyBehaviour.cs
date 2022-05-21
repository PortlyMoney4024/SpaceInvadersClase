using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform posSpawn;
    public int separacion;
    public static EnemyBehaviour respawn;

    void Start()
    {
        StartCoroutine(enemyShoot());
        SpawnearEnemigos();

        posSpawn = GetComponent<Transform>();
    }

    IEnumerator enemyShoot()
    {
        do
        {
            yield return new WaitForSeconds(1);
            eShoot();
        } while (true);
    }

    public void eShoot()
    {
        //Esta función toma el objeto desactivado disponible
        //Para utilizarlo al gusto
        GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = this.transform.position;
            bullet.transform.rotation = this.transform.rotation;
            bullet.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PlayerShot"))
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            //Destroy(collision.gameObject);

            GameManager.sharedInstance.DamageEnemies();

            collision.gameObject.SetActive(false);
        }
    }

    public void SpawnearEnemigos()
    {
        GameObject enemigos = ObjectPooler.SharedInstance.ChecarEnemigos();
        if (enemigos != null)
        {
            enemigos.transform.position = new Vector3(posSpawn.position.x, posSpawn.position.y + separacion, -10);
            enemigos.transform.rotation = this.transform.rotation;
            enemigos.SetActive(true);
        }
    }
}
