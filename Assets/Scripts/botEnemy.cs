using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botEnemy : MonoBehaviour {
    public GameObject Missile;

    void Start () {
        InvokeRepeating("shootMissile", 3.0f, 3.0f);
    }
	
	void Update () {
		
	}

    public void shootMissile ()
    {
        Instantiate(Missile);
    }
}
