using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public GameObject canvas;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

	void OnTriggerEnter(Collider c)
    {
        Debug.Log("Haha");
        canvas.SetActive(true);
    }

}
