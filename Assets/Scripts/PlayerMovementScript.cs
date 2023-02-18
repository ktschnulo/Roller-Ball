using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    //variables
    public float speed = 10;
    public float airSpeed = 5;
    public float jumpForce = 7.5f;
    public bool grounded = true;
    private Rigidbody myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //wasd movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (grounded == true)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            myRigidBody.AddForce(movement * speed);
        }
        else
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            myRigidBody.AddForce(movement * airSpeed);
        }
    }
    void Update()
    {
        //jump
        if (Input.GetKeyDown("space") && grounded == true)
        {
            myRigidBody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            grounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
