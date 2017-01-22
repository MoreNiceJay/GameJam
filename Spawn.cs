using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public float timeBetweenWaves;
	public int waveSize;
	public int spawnRange;

	public GameObject[] enemies;
	public int amount;

	private Vector3 spawnPoint;

	void Start() {
	
		waveSize = 20;
		spawnRange = 20;
		timeBetweenWaves = 5f;
	}

	// Update is called once per frame
	void Update () {
	
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		amount = enemies.Length;

		if (amount < waveSize) {
			InvokeRepeating ("spawnEnemy", 0.01f, 0.01f);
		}
	}



void spawnEnemy ()
{
		
		spawnPoint.x = Random.Range (-spawnRange, spawnRange);
		spawnPoint.y = 0.5f;
		spawnPoint.z = Random.Range (-spawnRange, spawnRange);

		Instantiate(enemies[ enemies.Length - 1],spawnPoint, Quaternion.identity);
		CancelInvoke ();
	}
}