using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

	private Vector2 Velocity;
	public float SmothTimeY;
	public float SmoothTimeX;

	public GameObject player;

	public bool bounds;

	public Vector3 minCameraPos;
	public Vector3 maxCAmeraPos;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");		
	}
	
	// Update is called once per frame
	void Update () {
		float Posx = Mathf.SmoothDamp (transform.position.x, player.transform.position.x, ref Velocity.x, SmoothTimeX);
		float PosY = Mathf.SmoothDamp (transform.position.y, player.transform.position.y, ref Velocity.y, SmothTimeY);

		transform.position = new Vector3 (Posx, PosY, transform.position.z);

		if (bounds) {
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, minCameraPos.x, maxCAmeraPos.x),
				Mathf.Clamp (transform.position.y, minCameraPos.y, maxCAmeraPos.y),
				Mathf.Clamp (transform.position.z, minCameraPos.z, maxCAmeraPos.z));
		}
	}
}
