using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {

	public float DragMultiply = 2;

	void OnTriggerStay2D(Collider2D MyCollider){
		if (MyCollider.gameObject.tag == "Player"){			
			MyCollider.gameObject.GetComponent<Rigidbody2D>().drag = DragMultiply;
		}
	}
	void OnTriggerExit2D(Collider2D MyCollider){
		if (MyCollider.gameObject.tag == "Player"){			
			MyCollider.gameObject.GetComponent<Rigidbody2D>().drag = 1;
		}
	}
}
