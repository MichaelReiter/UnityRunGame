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
	//private bool inMenu;

	void Start () {
		spawnCounter = 0;
		InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
	}

	void SpawnEnemy() {
		if (!GameObject.FindWithTag("UI").GetComponent<StartOptions>().inMainMenu) {
			spawnCounter++;
			Instantiate(enemy, spawnPoints[spawnCounter % spawnPoints.Length].point.position, spawnPoints[spawnCounter % spawnPoints.Length].point.rotation);
		}
	}
}
