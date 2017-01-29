using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
	GameObject splash;
	GameObject menu;
	GameObject scenario;
	// Use this for initialization

	void Awake () {
		//splash = Instantiate(Resources.Load("Splash")) as GameObject;
		//splash.transform.SetParent (gameObject.transform); 
		//splash.SetActive (false);

		menu = Instantiate(Resources.Load("MetaGame/MainMenu")) as GameObject;
		menu.transform.SetParent (gameObject.transform);
		//menu.SetActive (false);

		scenario = Instantiate(Resources.Load("Scenario")) as GameObject;
		scenario.transform.SetParent (gameObject.transform);
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
