using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    private float rotationSpeed = 500.0f;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Independent rotation of the propeller along the z axis 
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);  
    }
}
