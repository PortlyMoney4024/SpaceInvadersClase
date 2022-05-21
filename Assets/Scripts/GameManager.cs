using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;
    int health;
    public Text healthText;

    int score;
    public Text scoreTxt;

    void Awake()
    {
        sharedInstance = this;
    }

    void Start()
    {
        health = 5;
        healthText.text = "HEALTH = " + health;

        score = 0;
        scoreTxt.text = "SCORE = " + score;
    }

    void Update()
    {
        
    }

    public void TakeDamage() {
        health--;
        healthText.text = "HEALTH = " + health;

        if(health <= 0)
        {
            health = 5;
            healthText.text = "HEALTH = " + health;
            score = 0;
            scoreTxt.text = "SCORE = " + score;
            CambioEscenas.cambiarEscenas.GameOver();
        }
    }

    public void DamageEnemies()
    {
        score += 100;
        scoreTxt.text = "SCORE = " + score;

        if(score >= 3000)
        {
            health = 5;
            healthText.text = "HEALTH = " + health;
            score = 0;
            scoreTxt.text = "SCORE = " + score;
            CambioEscenas.cambiarEscenas.Victoria();            
        }
    }
}
