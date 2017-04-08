using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezer : BasePlayer {

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        Movement(playerNum + "_x", playerNum + "_z", playerNum + "_jump", playerNum + "_action");
    }

    protected override void Movement(string playerX, string playerZ, string jump, string action)
    {
        velocity = rb.velocity;
        Move(Input.GetAxisRaw(playerX), Input.GetAxisRaw(playerZ));
        if (Input.GetButtonDown(jump) && isGrounded)
        {
            Jump();
        }

        if(Input.GetButtonDown(action))
        {
            rb.isKinematic = !rb.isKinematic;
            if (!rb.isKinematic)
            {
                rb.velocity = new Vector3(0f, rb.velocity.y - yThreshold * 2, 0f);
            }
        }

        if ((rb.velocity.y <= yThreshold && rb.velocity.y >= -yThreshold) && !isGrounded && !rb.isKinematic)
        {
            isGrounded = true;
        }
    }
}
