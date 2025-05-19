using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public float damage;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    { //Code intended to subract health from player and initiate gameOver screen
        if (other.gameObject.CompareTag("player"))
        {
            other.gameObject.GetComponent<playerHealth>().health -= damage; 
        }
    }
}
