using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;

	private Animator anim;
	bool isDead;
	bool damaged = false;

	void Awake() {
		anim = GetComponent<Animator>();
		currentHealth = startingHealth;
	}

	public void TakeDamage(int amount) {
		damaged = true;
		currentHealth -= amount;
		Debug.Log("hit");
		damaged = false;
		if (currentHealth <= 0 && !isDead) {
			Death();
		}
	}

	void Death() {
		isDead = true;
		anim.SetTrigger("isDead");
	}
}
