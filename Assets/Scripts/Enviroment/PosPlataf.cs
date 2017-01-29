using UnityEngine;
using System.Collections;

public class PosPlataf : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Player")
		{
			transform.parent = collision.gameObject.transform;
		}
		else{
			transform.parent = null;
		}
	}
}
