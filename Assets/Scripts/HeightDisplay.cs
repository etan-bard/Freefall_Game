using UnityEngine;
using System.Collections;

public class HeightDisplay : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	void LateUpdate()
	{
		TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
		t.text = Mathf.RoundToInt((transform.position.y + 120)) + "";
	}
}
