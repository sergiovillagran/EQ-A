using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDamage : MonoBehaviour {

	public int AmountDamage = -25;

	public bool Condition = true;


	void OnTriggerStay2D(Collider2D MyCollider){
		if (MyCollider.gameObject.tag == "Player" && Condition){			
			MyCollider.gameObject.GetComponent<PlayerControl>().CalculateDamage(AmountDamage);
			Condition = false;
			StartCoroutine(MakeDamage());
		}
	}

	public IEnumerator MakeDamage()
	{
		yield return new WaitForSeconds(1);
		Condition = true;
	}
}
