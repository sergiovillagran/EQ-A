using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour {

	public Transform[] backgrounds; // Array de todos los BG en el parallax
	private float [] parallaxScales; // Movimiento de camara proporcional a el mov de los BG
	public float smoothing = 1f; // Smooth del parallax, arriba de 1

	private Transform cam; // Ref a la main camera
	private Vector3 previousCamPos; // La camara en el frame anterior, para el calculo del parallax 

	void Awake ()
	{
		//Refs
		cam = Camera.main.transform;

	}
	// Use this for initialization
	void Start () {
		// El frame anterior tiene la Pos de la cam
		previousCamPos = cam.position;

		// parallaxScales
		parallaxScales = new float[backgrounds.Length];
		for (int i = 0; i < backgrounds.Length; i++) 
		{
			parallaxScales [i] = backgrounds [i].position.z * -1;

		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		for (int i = 0; i < backgrounds.Length; i++) 
		{
			float parallax = (previousCamPos.x - cam.position.x) * parallaxScales [i];

			float backgroundTargetPosX = backgrounds[i].position.x + parallax;

			Vector3 backgroundTargetPos = new Vector3 (backgroundTargetPosX, backgrounds [i].position.y, backgrounds [i].position.z);

			backgrounds [i].position = Vector3.Lerp (backgrounds [i].position, backgroundTargetPos, smoothing * Time.deltaTime);

		}

		previousCamPos = cam.position;

	}
}
