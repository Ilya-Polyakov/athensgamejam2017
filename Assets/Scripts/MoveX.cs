using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : BasePlayer {


	// Use this for initialization
	void Start () {
        className = "Child";
        //floatVal = 222f;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        Movement(playerNum + "_x", playerNum + "_z", playerNum + "_jump", playerNum + "_action");
	}

    override protected void Movement(string playerX, string playerZ, string jump, string action)
    {
        Move(Input.GetAxisRaw(playerX), 0);
        if (Input.GetButton(jump) && isGrounded)
        {
            Jump();
        }
        if ((rb.velocity.y <= yThreshold && rb.velocity.y >= -yThreshold) && !isGrounded)
        {
            isGrounded = true;
        }
    }
}
