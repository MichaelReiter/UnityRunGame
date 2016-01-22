using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public float cooldown = 0.5f;
	public int attackDamage = 10;

	private Animator anim;
	private GameObject player;
	private PlayerHealth playerHealth;
	private EnemyHealth enemyHealth;
	private bool playerInRange;
	private float timer;

	void Awake() {
		player = GameObject.FindGameObjectWithTag("Player");
		playerHealth = player.GetComponent<PlayerHealth>();
		enemyHealth = GetComponent<EnemyHealth>();
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
		timer += Time.deltaTime;

		if (timer >= cooldown && playerInRange && enemyHealth.currentHealth > 0) {
			Attack();
		}

		if (playerHealth.currentHealth <= 0) {
			anim.SetTrigger("GameOver");
		}
	}

	void Attack() {
		timer = 0f;

		if (playerHealth.currentHealth > 0) {
			anim.SetTrigger("isAttacking");
			playerHealth.TakeDamage(attackDamage);
		}
	}
}
