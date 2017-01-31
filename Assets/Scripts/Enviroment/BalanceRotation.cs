using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceRotation : MonoBehaviour {
	public Animator anim;

	public bool IsTrigger = false;

	void Start(){
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		anim.SetBool("IsTrigger",IsTrigger);
	}

	// Update is called once per frame
	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player") {
			//anim.Play (anim.clip.name);
			IsTrigger = true;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		IsTrigger = false;
		//anim.Play ("Restart");
		//anim.Stop();		
	}
}
