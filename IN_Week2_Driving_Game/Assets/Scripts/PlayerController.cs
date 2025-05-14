using UnityEngine;

public class player : MonoBehaviour
{
    //setting the 'speed' field to to a speed of '6'
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
        // move the 'Pickup_Truck_Player' forward

        // method 1, transform.Translate(0,0, speed * Time.deltaTime * 20);

        // method 2, transform.Translate(Vector3.forward * Time.deltaTime * 20);

        // method 3, move forward in world space. eg. rb.AddForce(Vector3.forward * speed);

        // method 4  rb.AddRelativeForce(Vector3.forward * speed);
        
        rb.AddRelativeForce(Vector3.forward * speed);


        // add extra code setting if player car collides with NPC car, "you lose" will atcivate

       
    }
}
