using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	[SerializeField]
	float magnitude; // Force of the gravity. 1 = no gravity, less is falling up and more is falling down.
	[SerializeField]
	float jumpHeight;
	[SerializeField]
	GameObject pointKeeper;
	
	float jump;
	float fallSpeed; // Speed at which the object is falling.
	CharacterController controller;
	
	
	void Start () 
	{
		float jump = 0.0f;
		fallSpeed = 0.0f;
		controller = this.gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(controller.isGrounded)
		{
			fallSpeed = 0.0f;
			controller.Move (new Vector3(0.0f, 0.001f, 0.0f));
		}

		else
		{
			fallSpeed += 0.01f;
			fallSpeed *= magnitude;
			controller.Move (new Vector3(0.0f, -fallSpeed, 0.0f));
		}
		
		if(Input.GetButton("Jump") && fallSpeed < 0.01f)
		{
			jump = jumpHeight;
			fallSpeed = 0.0f;
		}
		
		if(jump > 0.0f)
		{
			controller.Move (new Vector3( 0.0f, jump, 0.0f));
			jump = (jump / 1.3f) - 0.01f;
		}
		
		if(transform.position.y <= -120.0f)
		{
			pointKeeper.SendMessage("EndGame");
			Destroy(this.gameObject);
		}
	}
}
