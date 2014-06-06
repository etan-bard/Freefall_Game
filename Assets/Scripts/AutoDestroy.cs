using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {

	[SerializeField]
	float milliseconds; // Milliseconds until the game object is destroyed.
	
	// Use this for initialization
	void Start () 
	{
		StartCoroutine("Destroy");
	}
	
	IEnumerator Destroy()
	{
		yield return StartCoroutine(Wait (milliseconds/100.0f));
		Destroy(gameObject);
	}
	
	IEnumerator Wait (float delay) 
	{
        float timer = Time.time + delay;
        while (Time.time < timer) 
            yield return null;
    }
}
