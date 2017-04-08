using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : BasePlayer {

	// Use this for initialization
	void Start () {
        //floatVal = 222f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        velocity = rb.velocity;
        Movement(playerNum + "_x", playerNum + "_z", playerNum + "_jump", playerNum + "_action");
	}
}
