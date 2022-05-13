using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;
    int health;
    public Text healthText;

    void Awake()
    {
        sharedInstance = this;
    }

    void Start()
    {
        health = 5;
        healthText.text = "HEALTH:" + health;
    }

    void Update()
    {
        
    }

    public void TakeDamage() {
        health--;
        healthText.text = "HEALTH:" + health;
    }
}
