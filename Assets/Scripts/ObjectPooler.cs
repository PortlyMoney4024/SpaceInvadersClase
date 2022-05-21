using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;

    public List<GameObject> listaObjetos;
    public GameObject balas;
    public int municion;
    
    public List<GameObject> listaEnemigos;
    public GameObject enemigos;
    public int cantEnemigos;

    void Awake()
    {
        SharedInstance = this;
    }
    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }

        listaObjetos = new List<GameObject>();
        for (int i = 0; i < municion; i++)
        {
            GameObject shot = (GameObject)Instantiate(balas);
            shot.SetActive(false);
            listaObjetos.Add(shot);
        }

        listaEnemigos = new List<GameObject>();
        for (int i = 0; i < cantEnemigos; i++)
        {
            GameObject spawn = (GameObject)Instantiate(enemigos);
            spawn.SetActive(false);
            listaObjetos.Add(spawn);
            if(cantEnemigos == 0)
            {
                cantEnemigos += 1;
            }
        }
    }

    void Update()
    {
        
    }

    public GameObject GetPooledObject()
    {
        //1
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            //2
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        //3   
        return null;
    }

    public GameObject ContarBalas()
    {
        for (int i = 0; i < listaObjetos.Count; i++)
        {
            if (!listaObjetos[i].activeInHierarchy)
            {
                return listaObjetos[i];
            }
        }  
        return null;
    }

    public GameObject ChecarEnemigos()
    {
        for (int i = 0; i < listaEnemigos.Count; i++)
        {
            if (!listaEnemigos[i].activeInHierarchy)
            {
                return listaEnemigos[i];
            }
        }
        return null;
    }
}
