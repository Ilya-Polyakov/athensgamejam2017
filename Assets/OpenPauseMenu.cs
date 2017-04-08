using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseMenu : MonoBehaviour {
	public GameObject menu;
	public GameObject winnerMenu;
	bool value = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			menu.SetActive(!value);
			value = !value;
		}
		//testing purposes
		if(Input.GetKeyDown(KeyCode.F10)){
			winnerMenu.SetActive(!value);
			value = !value;
		}
	}
}
