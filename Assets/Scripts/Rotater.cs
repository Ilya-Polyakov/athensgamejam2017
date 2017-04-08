using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : BasePlayer {

    float currentAngle = -90f;
    bool rotating = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        //currentAngle = rb.rotation.z;
	}
	
	// Update is called once per frame
	void Update () {
        RotateBlock(playerNum + "_x");
    }
    

    void RotateBlock(string playerX)
    {
        
        // ROTATE LEFT
        if(Input.GetAxisRaw(playerX) < 0 && currentAngle >= -90f && !rotating)
        {
            Quaternion targetAngle = Quaternion.Euler(currentAngle - 90f, 90f, -90f);
            currentAngle -= 90f;
            Debug.Log(currentAngle);
            StartCoroutine(RotateObject(targetAngle, 3f));
            //Quaternion rotation = Quaternion.Euler(0f, 0f, 90f)
            /*float timeDiff = 5f;
            while (timeDiff > 0)
            {
                timeDiff -= Time.deltaTime;
                rb.rotation = Quaternion.SlerpUnclamped(rb.rotation, Quaternion.Euler(-180, 90f, -90f), 3f);
                currentAngle = rb.rotation.x;
            }*/
        }
        // ROTATE RIGHT
        else if(Input.GetAxisRaw(playerX) > 0 && currentAngle <= -90f && !rotating)
        {
            Quaternion targetAngle = Quaternion.Euler(currentAngle + 90f, 90f, -90f);
            currentAngle += 90f;
            Debug.Log(currentAngle);
            StartCoroutine(RotateObject(targetAngle, 2f));
        }
        //rb.rotation = Quaternion.Euler(0f, 0f);
        
    }

    IEnumerator RotateObject(Quaternion newRot, float duration)
    {
        if (rotating)
        {
            yield break;
        }
        rotating = true;

        Quaternion currentRot = rb.rotation;

        float counter = 0f;
        while(counter < duration)
        {
            counter += Time.deltaTime;
            rb.rotation = Quaternion.Lerp(currentRot, newRot, counter / duration);
            yield return null;
        }
        rotating = false;
    }
}
