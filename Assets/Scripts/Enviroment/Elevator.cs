using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal enum TypeElevator
{
	Vertical,
	Horizontal,
	//Both
}
public class Elevator : MonoBehaviour {
	[SerializeField] private TypeElevator ElevatorOrientation;

	public float Distance;

	public float SpeedElevator = 0.9f;

	private float StartPosition;

	private float Timer = 0;

	private bool ReachElevator = false;

	// Use this for initialization
	void Start () {
		switch (ElevatorOrientation)
		{
		case TypeElevator.Vertical:
			StartPosition = transform.position.y;
			break;

		case TypeElevator.Horizontal:
			StartPosition = transform.position.x;
			break;
	}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player" && !ReachElevator) {
			StopAllCoroutines();
			ReachElevator = true;
			//Timer = 0;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player" && ReachElevator) {
			StartCoroutine(ChangeReach());
			//ReachElevator = false;
			//Timer = 1;
		}
	}
	void Update(){
		if (ReachElevator && Timer < 1)Timer += SpeedElevator*Time.deltaTime;
		if (!ReachElevator && Timer > 0)Timer -= SpeedElevator*Time.deltaTime;
	

	switch (ElevatorOrientation)
	{
	case TypeElevator.Vertical:
			transform.position = new Vector3(transform.position.x, Mathf.Lerp(StartPosition,StartPosition+Distance, Timer), transform.position.z);
			break;

	case TypeElevator.Horizontal:
			transform.position = new Vector3(Mathf.Lerp(StartPosition,StartPosition+Distance, Timer), transform.position.y, transform.position.z);
		break;
	}
		
}

	public IEnumerator ChangeReach()
	{
		yield return new WaitForSeconds(2f); 
		ReachElevator = false;

	}
}
