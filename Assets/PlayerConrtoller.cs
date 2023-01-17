using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConrtoller : MonoBehaviour
{
Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;
    
    public Transform mainCamera;

    // private float yaw = 0.0f;
    // private float pitch = 0.0f;

    // public float speedH = 2.0f;
    // public float speedV = 2.0f;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main.transform.parent.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
       
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        MouseMove();
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }


    void MouseMove()
    {
        // rb.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, 2.0f);
    }
  
}
