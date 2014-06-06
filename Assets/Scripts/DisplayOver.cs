using UnityEngine;
using System.Collections;

public class DisplayOver : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		pointPreserver = GameObject.FindGameObjectWithTag("PointPreserver");
		PointMessage messenger = new PointMessage();
		pointPreserver.SendMessage("SendScore", messenger);
		//int finalScore = messenger.score;
		Destroy(messenger);
		Destroy(pointPreserver);
		//pointResults.text = "Points: " + finalScore;
	}
	
	GameObject pointPreserver;
	
	[SerializeField]
	GUIText pointResults;
}

