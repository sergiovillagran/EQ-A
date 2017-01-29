using UnityEngine;
using System.Collections;

public class Plataforma : MonoBehaviour {

	public Transform startMarker;
	public Transform endMarker;
	public float duracion = 1.0f;

	//private variables

	private float lerp;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		lerp = Mathf.PingPong(Time.time,duracion)/duracion;
		transform.position = Vector3.Lerp(startMarker.position, endMarker.position, lerp);
		
	}
}
