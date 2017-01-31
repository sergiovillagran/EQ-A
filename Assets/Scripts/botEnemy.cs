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
        Vector3 missilePosition = Camera.main.transform.position - new Vector3(9, 1, 0);
        missilePosition.z = 0;
        Instantiate(Missile).transform.position = missilePosition;
    }
}
