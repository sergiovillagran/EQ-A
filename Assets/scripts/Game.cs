using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public iGame[] nodes;

    // Como accder a game y sus componentes

    // Como infomar a las otras clases del los eventos de monobehaviour

        // Tree build
    void Awake()
    {
        nodes    = new iGame[2];
        nodes[0] = Model.getInstance();
        nodes[0] = Controller.getInstance();
    }

    void Update() {
        model.update();
        control.update();
    }



}
/*
public class Game : MonoBehaviour {
	GameObject splash;
	GameObject menu;
	GameObject scenario;
	// Use this for initialization

	void Awake () {
		splash = Instantiate(Resources.Load("Splash")) as GameObject;
		splash.transform.SetParent (gameObject.transform); 
		splash.SetActive (false);

		menu = Instantiate(Resources.Load("MainMenu")) as GameObject;
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

    public void loadMeta()
    {

    }

    public void loadMissile()
    {

    }

	public void timer (string function, float delayTime){
		Invoke (function, delayTime);	
	}
}
*/