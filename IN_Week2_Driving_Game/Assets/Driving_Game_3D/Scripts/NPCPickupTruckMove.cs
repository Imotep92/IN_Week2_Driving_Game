using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCPickupTruckMove : MonoBehaviour
{
    public float speed = 6;

    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    // applies slight forward momentum to the NPC cars on the road
    void Update()
    {
        rb.AddRelativeForce(Vector3.forward * speed);
    }
}

