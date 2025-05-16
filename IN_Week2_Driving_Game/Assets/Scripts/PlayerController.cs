using UnityEngine;

public class player : MonoBehaviour
{
    private float speed = 50.0f;
    private float turnSpeed = 70.0f;
    private float horizontalInput;
    private float forwardInput;
    Rigidbody rb;

    public int playerIndex; //assigns each player with a control scheme mapped by either 1 or 2


    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }


    void Update()
    {

        forwardInput = Input.GetAxis("Vertical" + playerIndex); //
        horizontalInput = Input.GetAxis("Horizontal" + playerIndex);

        

        // Moves the car base on Vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Moves the car based on horizontal Input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
