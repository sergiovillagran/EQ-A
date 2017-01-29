using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundParallax : MonoBehaviour {

	private Renderer rend;
	public float scrollSpeed = 0.5F;

	private GameObject Player;

	private float offset;

	Rigidbody2D PlayerRigid;

	private float Speed;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();

		Player = GameObject.FindGameObjectWithTag("Player");

		PlayerRigid = Player.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		Speed = /*Player.transform.localScale.x * */PlayerRigid.velocity.x; // PlayerRigid.velocity.magnitude;
		//offset = Player.transform.localScale.x * Speed * scrollSpeed;
		offset += Speed/50000 * scrollSpeed;
		rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
}
