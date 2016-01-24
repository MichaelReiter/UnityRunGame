using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	public int scoreValue = 10;

	private Animator anim;
	private CapsuleCollider capsuleCollider;
	private bool isDead;

	void Awake() {
		anim = GetComponent<Animator>();
		capsuleCollider = GetComponent<CapsuleCollider>();

		currentHealth = startingHealth;
	}

	public void TakeDamage(int amount) {
		if (isDead) {
			return;
		}

		currentHealth -= amount;

		if (currentHealth <= 0) {
			Death();
		}
	}

	void Death() {
		isDead = true;

		// Allow shots to pass through
		capsuleCollider.isTrigger = true;
		anim.SetTrigger("isDead");
		GetComponent<NavMeshAgent>().enabled = false;
		GetComponent<Rigidbody>().isKinematic = true;
		Object.Destroy(gameObject, 2f);
	}
}
