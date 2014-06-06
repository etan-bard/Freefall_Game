using UnityEngine;
using System.Collections;

public class DynamicLighting : MonoBehaviour 
{

	void Start () 
	{
	
	}
	
	void FixedUpdate () 
	{
		float newColor = 1 + (transform.position.y / 80.0f); // Receives a color value the low the y value is.
		this.gameObject.light.color = new Vector4(1.0f - newColor, newColor, newColor, 1.0f);
	}
}
