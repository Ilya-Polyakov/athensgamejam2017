using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			SceneManager.LoadScene(4);
		}
		if (Input.GetKeyDown(KeyCode.W)) {
			Debug.Log("NextLevel");
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
