using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {
    //This is the character controller component
    private CharacterController myCC;
    // temp var of datatype vector 3 to move the character
    private Vector3 tempPos;
    //Speed of the temp var in x
    public float speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;

    //used to move player


    // Use this for initialization
    void Start() {
        //This "finds" the character component. Calls character controller on object
        myCC = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update() {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            
            tempPos.y = jumpSpeed;
        }

        tempPos.y -= gravity;

        tempPos.x = speed*Input.GetAxis("Horizontal");
        //deltaTime slows it to a manageable rate, no matter what the frame rate. Adds consitent time.
        myCC.Move(tempPos * Time.deltaTime);

    }
}
