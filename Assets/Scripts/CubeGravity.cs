using UnityEngine;
using System.Collections;

public class CubeGravity : MonoBehaviour {

	
	float fallSpeed; // Speed at which the object is falling.
	float acceleration;
	bool neverGrounded;
	CharacterController controller;
	
	void Start () 
	{
		neverGrounded = true;
		acceleration = 1.0f/Random.Range (25,75) + 0.25f;
		fallSpeed = 0.1f;
		controller = this.gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(neverGrounded)
		{
			fallSpeed = acceleration;
			controller.Move (new Vector3(0.0f, fallSpeed, 0.0f));
		}
	}

}
