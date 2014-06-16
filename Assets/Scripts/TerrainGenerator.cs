using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour 
{
	[SerializeField]
	GameObject block;
	[SerializeField]
	float mediumProbability; // 0 = no chance, 1000 = maximum probability.
	[SerializeField]
	float largeProbability; // 0 = no chance, 1000 = maximum probability.
	[SerializeField]
	float smallProbability; // 0 = no chance, 1000 = maximum probability.
	[SerializeField]
	float gigaProbability; // Chance of spawning an extra large block. 1 = max probability, greater = lower.
	
	void Start ()
	{
	}
	
	void FixedUpdate()
	{
		float random = Random.Range (0,3000);

		//if (random <= 333) 
		if(random <= 1000)
		{
			GameObject tile = Instantiate (block, new Vector3 (transform.position.x + (float)Mathf.RoundToInt (Random.Range(-40, 40)), transform.position.y + Random.Range(-25, 25), transform.position.z), transform.rotation) as GameObject;

			tile.transform.localScale = new Vector3 (3.0f, 3.0f, 3.0f);
			tile.renderer.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
		}
		/*if(random > 333 && random < 667)
		{
			GameObject tile = Instantiate (block, new Vector3 (transform.position.x + (float)Mathf.RoundToInt (Random.Range (-40, 40)), transform.position.y + Random.Range(-10, 10), transform.position.z), transform.rotation) as GameObject;
			tile.transform.localScale = new Vector3(4.0f, 4.0f, 4.0f);
			tile.renderer.material.color = Color.magenta;
		}
		if(random < 1000 && random >= 667)
		{
			GameObject tile = Instantiate(block, new Vector3(transform.position.x + (float)Mathf.RoundToInt (Random.Range(-40,40)), transform.position.y + Random.Range(-10, 10), transform.position.z), transform.rotation) as GameObject;
			tile.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
			tile.renderer.material.color = Color.yellow;
		}*/
	}
}
