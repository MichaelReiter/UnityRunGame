using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject enemy;
	public float spawnInterval;
	public Transform spawnPoint;

	void Start () {
		InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
	}

	void SpawnEnemy() {
		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
	}
}
