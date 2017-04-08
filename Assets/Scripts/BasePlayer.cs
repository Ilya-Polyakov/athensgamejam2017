using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour {

    public float floatVal = 793f;
    public string className = "Parent";
    public float movementSpeed = 5.0f, jumpSpeed = 5.0f;
    [SerializeField] protected string playerNum;
    protected Rigidbody rb;
    protected bool isGrounded = true;
    protected float yThreshold = 0.05f;
    protected Vector3 velocity;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
   	}

    virtual protected void Movement(string playerX, string playerZ, string jump, string action)
    {
        Move(Input.GetAxisRaw(playerX), Input.GetAxisRaw(playerZ));
        if (Input.GetButton(jump) && isGrounded)
        {
            Jump();
        }
        //FOR FLOOR
        /*
        if (rb.velocity.y == 0 && !isGrounded)
        {
            isGrounded = true;
            Debug.Log("FLOOR JUMP");
        }*/
        
        //FOR BLOCKS
        if((rb.velocity.y <= yThreshold && rb.velocity.y >= -yThreshold) && !isGrounded)
        {
            isGrounded = true;
        }
    }

    protected void Jump()
    {
        isGrounded = false;
        Vector3 jumpVelocity = rb.velocity;
        jumpVelocity.y = jumpSpeed;
        rb.velocity = jumpVelocity;
    }

    protected void Move(float horizontalXInput, float horizontalZInput)
    {
        Vector3 moveVelocity = rb.velocity;
        moveVelocity.x = horizontalXInput * movementSpeed;
        moveVelocity.z = horizontalZInput * movementSpeed;
        rb.velocity = moveVelocity;
    }
}
