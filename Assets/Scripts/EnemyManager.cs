using UnityEngine;
using System.Collections;

[System.Serializable]
public class SpawnPoint {
	public Transform point;
}

public class EnemyManager : MonoBehaviour {

	public GameObject enemy;
	public float spawnInterval;
	public SpawnPoint[] spawnPoints;

	private int spawnCounter;

	void Start () {
		spawnCounter = 0;
		InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
	}

	void SpawnEnemy() {
		spawnCounter++;
		Instantiate(enemy, spawnPoints[spawnCounter % spawnPoints.Length].point.position, spawnPoints[spawnCounter % spawnPoints.Length].point.rotation);
	}
}
