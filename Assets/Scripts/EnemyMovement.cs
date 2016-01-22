using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	Transform player;


	NavMeshAgent nav;
	Rigidbody rb;

	void Awake() {
		player = GameObject.FindGameObjectWithTag("Player").transform;


		nav = GetComponent<NavMeshAgent>();
		rb = GetComponent<Rigidbody>();
	}
	
	void Update() {
		nav.SetDestination(player.position);
	}
}
