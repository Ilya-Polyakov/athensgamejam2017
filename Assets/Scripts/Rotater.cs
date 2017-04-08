using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : BasePlayer {

    float currentAngle = 0f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    

    void RotateBlock(string playerX)
    {
        // ROTATE LEFT
        if(Input.GetAxisRaw(playerX) < 0 &&)
        {
            Quaternion rotation = Quaternion.Euler(0f, 0f, 90)
            rb.rotation = Quaternion.Euler(0f, 0f);
        }
        // ROTATE RIGHT
        else if(Input.GetAxisRaw(playerX) > 0)
        {
            rb.rotation = Quaternion.Euler(0f, 0f);
        }
        //rb.rotation = Quaternion.Euler(0f, 0f);
    }
}
