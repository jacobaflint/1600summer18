using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour
{
	public GameObject AI;
	public Transform Destination;
	public Level CurrentLevel;
	private int AICount;

	// Use this for initialization
	void Start()
	{
		AICount = CurrentLevel.AICount;
		StartCoroutine(StartSpawn());
	}

	private IEnumerator StartSpawn()
	{
		while (AICount > 0)
		{
			GameObject newAI = Instantiate(AI);
			newAI.GetComponent<AIMovement>().Destination = Destination;
			AICount--;

			yield return new WaitForSeconds(CurrentLevel.Time);
		}
	}
}
