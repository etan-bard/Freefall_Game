using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	Vector3 moveDecay;
	Vector3 formerSpawn;
	GameObject TerrainFactory;
	GameObject Movement;
	bool first;
	CharacterController controller;
	
	[SerializeField]
	float maxSpeed;
	
	// Use this for initialization
	void Start () 
	{
		controller = this.gameObject.GetComponent<CharacterController>();
		first = true;
		moveDecay = new Vector3(0.0f,0.0f,0.0f);
		TerrainFactory = (GameObject)GameObject.FindGameObjectWithTag("Respawn");
		Movement = (GameObject)GameObject.FindGameObjectWithTag("MainCamera");
		formerSpawn = new Vector3(0.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.position += moveDecay;
		
		if(transform.position.x % 10.0f <= maxSpeed && first)
		{
			// Condition if we have moved 10 units 
			int xVal = Mathf.RoundToInt(transform.position.x);
			first = false;
		}
		else if(transform.position.x % 10.0f > maxSpeed)
		{
			first = true;
		}
			
		if(Input.GetButton("Right") && moveDecay.x < maxSpeed)
		{
			moveDecay += new Vector3(0.03f, 0.0f, 0.0f);
		}
		else if(Input.GetButton("Left") && moveDecay.x > -maxSpeed)
		{
			moveDecay -= new Vector3(0.03f,0.0f,0.0f);
		}
		else
		{
			moveDecay = moveDecay/2.2f;
		}
	}	
}
