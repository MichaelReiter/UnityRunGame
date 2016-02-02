using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	//public float cooldown = 0.5f;
	public int attackDamage = 10;

	private Animator anim;
	private GameObject player;
	private PlayerHealth playerHealth;
	private bool playerInRange;
	private float attackTimer;

	void Awake() {
		player = GameObject.FindGameObjectWithTag("Player");
		playerHealth = player.GetComponent<PlayerHealth>();
		anim = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			playerInRange = true;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			playerInRange = false;
		}
	}

	void Update() {
		attackTimer += Time.deltaTime;

		if (/*attackTimer >= cooldown && */playerInRange) {
			Attack();
		}

		if (playerHealth.currentHealth <= 0) {
			anim.SetTrigger("GameOver");
		}
	}

	void Attack() {
		attackTimer = 0f;

		if (playerHealth.currentHealth > 0) {
			anim.SetTrigger("isAttacking");
			Invoke("KillPlayer", 0.5f);
		}
	}

	void KillPlayer() {
		playerHealth.Death();
	}
}
