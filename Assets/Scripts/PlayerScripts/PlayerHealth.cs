using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	//public Image damageImage;

	private Animator anim;
	bool isDead;
	bool damaged;

	void Awake() {
		anim = GetComponent<Animator>();

		currentHealth = startingHealth;
	}

	void Update() {
		if (damaged) {
			//
		} else {
			//
		}

		damaged = false;
	}

	public void TakeDamage(int amount) {
		damaged = true;

		currentHealth -= amount;

		if (currentHealth <= 0 && !isDead) {
			Death();
		}
	}

	void Death() {
		isDead = true;

		anim.SetTrigger("isDead");
	}
}
