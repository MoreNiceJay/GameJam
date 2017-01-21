using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject[] enemies;
	public int amountOfEnemy;
	private Vector3 spawnPoint;
	public float timeBetweenEnemies;


	// Update is called once per frame
	void Update () {
	
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		int amount = enemies.Length;

		if (amount < amountOfEnemy) 
		{
			InvokeRepeating ("spawnEnemy", timeBetweenEnemies, timeBetweenEnemies);
		}


	}


void spawnEnemy ()
{
	spawnPoint.x = Random.Range (-20, 20);
	spawnPoint.y = 0.5f;
	spawnPoint.z = Random.Range (-20, 20);

		Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length -1)],spawnPoint, Quaternion.identity);

	}
}