using UnityEngine;
using System.Collections;

public class Dropoff : MonoBehaviour 
{

	float magnitude;
	// Use this for initialization
	void Start () 
	{
		magnitude = 0.005f;
		gameObject.renderer.material.color = new Vector4(1.0f, 0.0f, 0.0f, 0.5f);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.position = new Vector3(0.0f, transform.position.y + (magnitude), 0.0f);
		magnitude = magnitude * 1.0001f;
	}
}
