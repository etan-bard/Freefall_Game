using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour 
{
	[SerializeField]
	GameObject block;
	[SerializeField]
	float mediumProbability; // 1000 = no chance, 0 = maximum probability.
	[SerializeField]
	float largeProbability; // 1000 = no chance, 0 = maximum probability.
	[SerializeField]
	float smallProbability; // 0 = no chance, 1000 = maximum probability.
	[SerializeField]
	float gigaProbability; // Chance of spawning an extra large block. 1 = max probability, greater = lower.
	
	void Start ()
	{
	}
	
	void FixedUpdate()
	{
		float random = Random.Range (0,1000);
		if(true)
		{
			GameObject tile = Instantiate(block, new Vector3(transform.position.x + (float)Mathf.RoundToInt (Random.Range(-40,40)), transform.position.y, transform.position.z), transform.rotation) as GameObject;
			if(random < largeProbability)
			{
				tile.transform.localScale = new Vector3(5.0f,5.0f,5.0f);
				tile.renderer.material.color = Color.cyan;
			}
			if(random % gigaProbability == 0)
			{
				GameObject special = Instantiate(block, new Vector3(transform.position.x + (float)Mathf.RoundToInt (Random.Range(-40,40)), transform.position.y, transform.position.z), transform.rotation) as GameObject;
				special.transform.localScale = new Vector3(7.0f,7.0f,7.0f);
				special.renderer.material.color = Color.blue;
			}
		}
		if(random < smallProbability)
		{
			GameObject tile = Instantiate(block, new Vector3(transform.position.x + (float)Mathf.RoundToInt (Random.Range(-40,40)), transform.position.y, transform.position.z), transform.rotation) as GameObject;
			tile.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
			tile.renderer.material.color = Color.yellow;
		}
	}
}
