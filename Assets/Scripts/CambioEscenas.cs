using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenas : MonoBehaviour
{
    public static CambioEscenas cambiarEscenas;

    public GameObject panelMenu;
    public GameObject panelGameOver;
    public GameObject panelVictoria;
    bool juegoDetenido = false;

    void Awake()
    {
        cambiarEscenas = this;
    }

    private void Start()
    {
        Menu();
    }

    /*
    public void Comenzar()
    {
        SceneManager.LoadScene("Main");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    */

    public void Menu()
    {
        juegoDetenido = true;
        Time.timeScale = 0f;
        panelMenu.SetActive(true);
        panelGameOver.SetActive(false);
        panelVictoria.SetActive(false);
    }

    public void EmpezarJuego()
    {
        juegoDetenido = false;
        Time.timeScale = 1f;
        panelMenu.SetActive(false);
        panelGameOver.SetActive(false);
        panelVictoria.SetActive(false);

        ObjectPooler.SharedInstance.ChecarEnemigos();
    }

    public void Victoria()
    {
        juegoDetenido = true;
        Time.timeScale = 0f;
        panelMenu.SetActive(false);
        panelGameOver.SetActive(false);
        panelVictoria.SetActive(true);
    }

    public void GameOver()
    {
        juegoDetenido = true;
        Time.timeScale = 0f;
        panelMenu.SetActive(false);
        panelGameOver.SetActive(true);
        panelVictoria.SetActive(false);
    }
}
