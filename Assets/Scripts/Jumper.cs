using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : BasePlayer {

    

	// Use this for initialization
	void Start () {
        jumpSpeed = 7f;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        Movement(playerNum + "_x", playerNum + "_z", playerNum + "_jump", playerNum + "_action");
    }
}
