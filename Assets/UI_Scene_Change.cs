using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Scene_Change : MonoBehaviour {
//	public int scene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SceneChange (int x) {
        Debug.Log(x);
		SceneManager.LoadScene (x);
	}
}
