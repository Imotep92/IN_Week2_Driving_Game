using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float movespeed = 1f;
    public Vector3 moveDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * movespeed * Time.deltaTime);
        
    }
}
