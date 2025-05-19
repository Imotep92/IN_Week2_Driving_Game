using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingRotatingObject : MonoBehaviour
{
    public float floatHeight = 1f;
    public float floatSpeed = 1f;
    public float rotationSpeed = 30f; // Adjust the speed of rotation

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new Y position based on sine wave for floating effect
        float newY = initialPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Update the object's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Rotate the object around its up axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

}
