using UnityEngine;

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
    void Update()
    {
        rb.AddRelativeForce(Vector3.forward * speed);
    }
}

