 using UnityEngine;
using System.Collections;

public class PointKeeper : MonoBehaviour {
	
	[SerializeField]
	float pointInterval;
	[SerializeField]
	GameObject preserveScore;
	
	int points;
	
	// Use this for initialization
	void Start () 
	{
		points = 0;
		StartCoroutine("PointGain");
	}
	
	void LateUpdate()
	{
		this.guiText.text = points + "";
	}
	
	// Update is called once per frame
	private IEnumerator PointGain() 
	{
		while(true)
		{
			yield return StartCoroutine("Wait", pointInterval);
			points++;
		}
	}
	
	void AddPoints(int toAdd)
	{
		points += toAdd;
	}
	
	void EndGame()
	{
		GameObject scoreMessage = Instantiate(preserveScore, new Vector3(0,0,0), transform.rotation) as GameObject;
		scoreMessage.SendMessage("CumulateScore", points);
		DontDestroyOnLoad(scoreMessage);
		Application.LoadLevel("EndGameScene");
	}
	
	IEnumerator Wait (float sec) 
	{
        float timer = Time.time + sec;
        while (Time.time < timer) 
            yield return null;
    }
}
