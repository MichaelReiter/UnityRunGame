using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	Transform player;
	PlayerHealth playerHealth;
	EnemyHealth enemyHealth;
	NavMeshAgent nav;

	void Awake() {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		playerHealth = player.GetComponent<PlayerHealth>();
		enemyHealth = GetComponent<EnemyHealth>();
		nav = GetComponent<NavMeshAgent>();
	}
	
	void Update() {
		nav.SetDestination(player.position);
	}
}
