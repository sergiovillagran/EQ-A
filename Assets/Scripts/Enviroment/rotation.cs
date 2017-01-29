using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	private Rigidbody2D myRigid;

	private ConstantForce2D stabilizator;

	private float GameObjectStartRotZ;

	private float RotationComparationZ;

	public float TorqueAdjustment = 30000;

	void Start(){
		myRigid = gameObject.GetComponent<Rigidbody2D>();
		stabilizator = gameObject.GetComponent<ConstantForce2D>();
		GameObjectStartRotZ = transform.rotation.z;
		myRigid.freezeRotation = false;
	}

	void Update(){
		RotationComparationZ = (-GameObjectStartRotZ) + transform.rotation.z;

		stabilizator.torque = (-RotationComparationZ) * TorqueAdjustment;

	}
}
