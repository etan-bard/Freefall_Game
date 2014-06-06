using UnityEngine;
using System.Collections;

public class PointMessage : MonoBehaviour 
{
	
	private int score;
	// Use this for initialization
	void Start () 
	{
		score = 0;
	}
	
	void CumulateScore(int points)
	{
		score = points;
	}
	
	void SendScore(PointMessage messenger)
	{
		messenger.score = this.score;
	}
}
