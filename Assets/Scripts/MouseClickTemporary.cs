using UnityEngine;
using System.Collections;

public class MouseClickTemporary : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown()
	{
		Application.LoadLevel("MainGameScene");
	}
}
