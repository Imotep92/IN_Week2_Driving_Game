using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;

        //camera set at a 90 degree angle parallel to plane
        transform.rotation = Quaternion.Euler(0, -90, 0);
    }
}
