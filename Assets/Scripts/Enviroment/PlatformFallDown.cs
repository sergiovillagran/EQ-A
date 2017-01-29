using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal enum TipoPlataforma
{
	Vertical,
	Horizontal,
	//Both
}
[ExecuteInEditMode]
public class PlatformFallDown : MonoBehaviour {
	[SerializeField] private TipoPlataforma HowisMyPlatform;

	private Rigidbody2D myRigid;

	private ConstantForce2D stabilizator;

	private float GameObjectStartY;

	private float GameObjectStartX;

	private float positionComparationY;

	private float positionComparationX;

	public float ForceAdjustment = 10;

	// Use this for initialization
	void Start () {
		myRigid = gameObject.GetComponent<Rigidbody2D>();
		stabilizator = gameObject.GetComponent<ConstantForce2D>();
		GameObjectStartY = transform.position.y;
		GameObjectStartX = transform.position.x;
		//myRigid.freezeRotation = true;

	}

	void Update(){
		switch (HowisMyPlatform)
		{
		case TipoPlataforma.Vertical:
			//myRigid.constraints = RigidbodyConstraints2D.FreezePositionX;
			positionComparationY = (-GameObjectStartY) + transform.position.y;

			stabilizator.force = (-positionComparationY) * ForceAdjustment * Vector2.up;
			break;
		
		case TipoPlataforma.Horizontal:
			//myRigid.constraints = RigidbodyConstraints2D.FreezePositionY;
			positionComparationX = (-GameObjectStartX) + transform.position.x;

			stabilizator.force = (-positionComparationX) * ForceAdjustment * Vector2.right;
		break;

		/*case TipoPlataforma.Both:
			myRigid.constraints = RigidbodyConstraints2D.FreezeRotation;
			positionComparationX = (-GameObjectStartX) + transform.position.x;
			stabilizator.force = (-positionComparationX) * ForceAdjustment * Vector2.left;
			positionComparationY = (-GameObjectStartY) + transform.position.y;
			stabilizator.force = (-positionComparationY) * ForceAdjustment * Vector2.up;
			break;*/
	}


//		positionComparation = (-GameObjectY) + transform.position.y;
//
//		stabilizator.force = (-positionComparation) * ForceAdjustment * Vector2.up;

	}
}
