using UnityEngine;
using System.Collections;

public class CubeGravity : MonoBehaviour {

	
	float fallSpeed; // Speed at which the object is falling.
	CharacterController controller;
	
	void Start () 
	{
		fallSpeed = 0.1f;
		controller = this.gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(controller.isGrounded)
		{
			//fallSpeed = 0.0f;
			controller.Move (new Vector3(0.0f, -0.001f, 0.0f));
		}

		else
		{
			fallSpeed = 0.1f;
			controller.Move (new Vector3(0.0f, fallSpeed, 0.0f));
		}
	}
}
