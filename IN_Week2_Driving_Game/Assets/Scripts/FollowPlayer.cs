using UnityEngine;


public class FollowPlayer : MonoBehaviour
{

    //public reference game object of 'Player'
    public GameObject player;
    
    //private reference to camera position in scene
    public Vector3 thirdPersonCameraOffset = new Vector3(0, 5, -7);

    //public reference to FPScamera so Unity can access it

    public Vector3 fpsCamOffset;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = player.transform.position + thirdPersonCameraOffset;


        // if statment to change camera views from third person offset to 'fpsCamOffset'
        if(Input.GetKeyDown(KeyCode.P))
        {
            thirdPersonCameraOffset = fpsCamOffset;
        }

        if(Input.GetKeyDown(KeyCode.O))
        {
            thirdPersonCameraOffset = new Vector3(0, 5, -7);
        }

        
    }
}
