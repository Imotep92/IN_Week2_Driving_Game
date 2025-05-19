using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public float health;

    private bool isDead;

    public gameManagerScript gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { //playerhealth script intended to hold the player hp, 1 point deducted per crash
        if (health <= 0 && !isDead)
        {
            isDead = true;
            gameManager.gameOver();
            Debug.Log("Dead");
        }
    }
}
