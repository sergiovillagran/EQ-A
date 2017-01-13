using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
	GameObject splash;
	GameObject menu;
	GameObject scenario;
	// Use this for initialization

	void Awake () {
		splash = Instantiate("splash") as GameObject;
		splash.transform.SetParent = gameObject; 
		splash.SetActive (false);

		menu = Instantiate("menu");
		menu.transform.SetParent = gameObject;
		menu.SetActive (false);

		scenario = Instantiate("scenario");
		scenario.transform.SetParent = gameObject;
		scenario.SetActive (false);
	}

	void Start () {
				
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void timer (string function, float delayTime){
		Invoke (function, delayTime);	
	}
}
